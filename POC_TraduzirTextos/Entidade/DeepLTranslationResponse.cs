using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace POC_TraduzirTextos.Entidade
{
    public class DeepLTranslationResponse
    {
        [JsonPropertyName("translations")]
        public List<Translation> Translations { get; set; }
    }
}
