namespace ECommerce.Models
{
    public class Item{
        //Propriedades & atributos
        public int Quantidade{get;set;}
        public decimal Valor{get;set;}
        public Produto Produto {get;set;} // is - a
    }
}