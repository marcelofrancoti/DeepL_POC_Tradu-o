using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_TraduzirTextos.Service
{
    public interface ITranslationService
    {
        Task<string> TranslateAsync(string text, string targetLanguage);
    }
}
