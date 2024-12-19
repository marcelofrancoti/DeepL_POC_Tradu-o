using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using POC_TraduzirTextos.Entidade;

namespace POC_TraduzirTextos.Service
{
    public class DeepLTranslationService : ITranslationService
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"; //insira aqui sua chave da deepl

        public DeepLTranslationService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> TranslateAsync(string text, string targetLanguage)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    return "Erro: Texto de entrada está vazio ou inválido.";
                }

                string url = $"https://api-free.deepl.com/v2/translate?auth_key={ApiKey}&text={Uri.EscapeDataString(text)}&target_lang={targetLanguage.ToUpper()}";
                Console.WriteLine($"Chamando a API com URL: {url}");

                HttpResponseMessage response = await _httpClient.GetAsync(url);
                Console.WriteLine($"Status da Resposta: {response.StatusCode}");

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Resposta JSON: {jsonResponse}");

                var translationResult = JsonSerializer.Deserialize<DeepLTranslationResponse>(jsonResponse);
                var translation = translationResult?.Translations?[0];

                return !string.IsNullOrWhiteSpace(translation?.Text) ? translation.Text : "Erro na tradução: Resposta vazia.";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao traduzir: {ex.Message}");
                return $"Erro ao traduzir: {ex.Message}";
            }
        }
    }
}
