using System.Text.Json;
using POC_TraduzirTextos.Entidade;
using POC_TraduzirTextos.Service;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Tradutor de Relatórios!");


        var relatorio = new Relatorio
        {
            Titulo = "Relatório Anual de Vendas",
            Autor = "João Silva",
            DataCriacao = DateTime.Now.ToString("dd/MM/yyyy"),
            Resumo = "Este relatório contém um resumo detalhado das vendas realizadas durante o ano de 2024.",
            Secoes = new List<Secao>
            {
                new Secao
                {
                    Titulo = "Introdução",
                    Conteudo = "O ano de 2024 foi marcado por grandes avanços nas vendas e novos mercados."
                },
                new Secao
                {
                    Titulo = "Resultados",
                    Conteudo = "As vendas aumentaram 20% em relação ao ano anterior, com destaque para o setor de tecnologia."
                },
                new Secao
                {
                    Titulo = "Conclusão",
                    Conteudo = "O ano foi extremamente positivo, e esperamos continuar crescendo nos próximos anos."
                }
            }
        };

        Console.WriteLine("Traduzindo o relatório...");

        var translationService = new DeepLTranslationService();

        // Traduzir todas as propriedades do relatório
        relatorio.Titulo = await translationService.TranslateAsync(relatorio.Titulo, "en");
        relatorio.Autor = await translationService.TranslateAsync(relatorio.Autor, "en");
        relatorio.Resumo = await translationService.TranslateAsync(relatorio.Resumo, "en");

        foreach (var secao in relatorio.Secoes)
        {
            secao.Titulo = await translationService.TranslateAsync(secao.Titulo, "en");
            secao.Conteudo = await translationService.TranslateAsync(secao.Conteudo, "en");
        }

        Console.WriteLine("Relatório traduzido:");
        Console.WriteLine(JsonSerializer.Serialize(relatorio, new JsonSerializerOptions { WriteIndented = true }));
    }
}


