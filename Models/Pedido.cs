using System;
using System.Collections.Generic;


namespace ECommerce.Models
{

    public class Pedido{
        public int IdPedido {get;set;}
        public Cliente Cliente {get;set;}
        public DateTime Data{get;set;}
        public List<Item> Itens {get;set;}
        public decimal Total {get;set;}
    }
}