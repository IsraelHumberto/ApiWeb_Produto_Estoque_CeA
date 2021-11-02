using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb_Produto_Estoque_CeA.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string setor { get; set; }
        public string tipo { get; set; }
        public string local { get; set; }
        public string fornecedor { get; set; }
        public int quantidade { get; set; }
        public string image { get; set; }
        public int codigo { get; set; }

    }
}
