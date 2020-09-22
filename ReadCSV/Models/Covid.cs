using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadCSV.Models
{
    public class Covid
    {
        public string MUNICIPIO { get; set; }
        public string NOME_ESTABELECIMENTO_SAUDE { get; set; }
        
        public int N_LEITOS_UTI_ADULTO { get; set; }
        public int N_LEITOS_CLINICOS_ADULTO { get; set; }
        public int N_LEITOS_UTI_PEDRIATRICO { get; set; }
        public int N_RESPIRADORES { get; set; }
        public int N_SUSPEITOS_COVIDSRAG_LEITO_UTI_ADULTO { get; set; }
        public int N_CONFIRMADOS_COVID_LEITO_UTI_ADULTO { get; set; }
        public int N_SUSPEITOS_COVIDSRAG_LEITO_UTI_PEDIATRICO { get; set; }
        public int N_CONFIRMADOS_COVID_LEITO_UTI_PEDIATRICO { get; set; }
        public int N_ADULTOS_UTILIZANDO_RESPIRADORES_UTI { get; set; }



    }
}
