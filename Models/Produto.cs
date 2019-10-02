using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models


{
    public class Produto
    //Propriedades  & atributos:
    {

        public int? IdProduto{get; set;}

        [Display(Name="Nome")]
        [Required (ErrorMessage="Campo nome obrigatório")]
        
        public string Nome{get;set;}

        [Required (ErrorMessage="Campo descricao obrigatório")]
        public string Descricao{get;set;}

        [Required (ErrorMessage="Campo valor obrigatório")]
        [DataType (DataType.Currency)]
        public decimal Valor{get;set;}
    }
}