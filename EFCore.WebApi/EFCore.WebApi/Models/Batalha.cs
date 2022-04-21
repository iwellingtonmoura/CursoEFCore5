using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace EFCore.WebApi.Models
{
    public class Batalha
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime Date { get; set; }
        public List<HeroiBatalha> HeroisBatalhas { get; set; }

    }
}
    