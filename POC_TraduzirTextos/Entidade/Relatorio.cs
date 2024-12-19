using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_TraduzirTextos.Entidade
{
    public class Relatorio
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string DataCriacao { get; set; }
        public string Resumo { get; set; }
        public List<Secao> Secoes { get; set; }
    }
}
