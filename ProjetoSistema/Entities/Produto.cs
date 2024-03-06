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
        public decimal ValorVenda { get; set; }

        public decimal ValorCusto { get; set; }
        public decimal ValorCompra { get; set; }
        public string GTIN { get; set; }
        public string CST{  get; set; }
        public  string NCM { get; set; }
        public bool Ativo {  get; set; }
    }

}
