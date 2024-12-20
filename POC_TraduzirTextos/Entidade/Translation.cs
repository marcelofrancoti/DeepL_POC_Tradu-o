﻿using System.Text.Json.Serialization;

namespace POC_TraduzirTextos.Entidade
{
    public class Translation
    {
        [JsonPropertyName("detected_source_language")]
        public string DetectedSourceLanguage { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

}
