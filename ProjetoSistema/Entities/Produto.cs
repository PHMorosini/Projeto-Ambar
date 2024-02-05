using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistema.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal VlrVenda { get; set; }

        public decimal VlrCusto { get; set; }
        public decimal VlrCompra { get; set; }
        public string GTIN { get; set; }
        public string Cst {  get; set; }
        public  string Ncm { get; set; }
        public bool Ativo {  get; set; }
    }

}
