using CsvHelper.Configuration;
using ReadCSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadCSV.Mappers
{
    public sealed class CovidMap : ClassMap<Covid> 
    {
        public CovidMap()
        {
            Map(x => x.MUNICIPIO).Name("MUNICIPIO");
            Map(x => x.NOME_ESTABELECIMENTO_SAUDE).Name("NOME_ESTABELECIMENTO_SAUDE");
            Map(x => x.N_LEITOS_UTI_ADULTO).Name("N_LEITOS_UTI_ADULTO");
            Map(x => x.N_LEITOS_CLINICOS_ADULTO).Name("N_LEITOS_CLINICOS_ADULTO");
            Map(x => x.N_LEITOS_UTI_PEDRIATRICO).Name("N_LEITOS_UTI_PEDRIATRICO");
            Map(x => x.N_RESPIRADORES).Name("N_RESPIRADORES");
            Map(x => x.N_SUSPEITOS_COVIDSRAG_LEITO_UTI_ADULTO).Name("N_SUSPEITOS_COVIDSRAG_LEITO_UTI_ADULTO");
            Map(x => x.N_CONFIRMADOS_COVID_LEITO_UTI_ADULTO).Name("N_CONFIRMADOS_COVID_LEITO_UTI_ADULTO");
            Map(x => x.N_SUSPEITOS_COVIDSRAG_LEITO_UTI_PEDIATRICO).Name("N_SUSPEITOS_COVIDSRAG_LEITO_UTI_PEDIATRICO");
            Map(x => x.N_CONFIRMADOS_COVID_LEITO_UTI_PEDIATRICO).Name("N_CONFIRMADOS_COVID_LEITO_UTI_PEDIATRICO");
            Map(x => x.N_ADULTOS_UTILIZANDO_RESPIRADORES_UTI).Name("N_ADULTOS_UTILIZANDO_RESPIRADORES_UTI");


        }
    }

}
