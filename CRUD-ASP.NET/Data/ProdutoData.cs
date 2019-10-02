using System.Data.SqlClient;
using ECommerce.Models;
using System.Collections.Generic;
using System;

namespace ECommerce.Data
{
public class ProdutoData : IDisposable
    {
        private SqlConnection connection;

        public ProdutoData()
        {
          string strConn = @"Data Source=localhost; Initial Catalog=BDEcommerce; Integrated Security= true";
          connection = new SqlConnection(strConn);
          connection.Open();
        }

        public void Dispose()
        {
          connection.Close();
        }

        //Métodos para minipular a tabela Produto do bando de dados
        public List<Produto> Read()
        {
          List<Produto> lista = new List<Produto>();
          
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = connection;
          //cmd.CommandType = System.Data.CommandType.StoredProcedure;
          cmd.CommandText = "SELECT * FROM Produto";

          SqlDataReader reader = cmd.ExecuteReader(); // Inseriu a consulta de produtos dentro do reader
          
          while(reader.Read())
          {
              Produto p = new Produto();
              p.IdProduto = (int)reader["IdProduto"];
              p.Nome = (string)reader["Nome"];
              p.Descricao = (string)reader["Descricao"];
              p.Valor = (decimal)reader["Valor"];

              lista.Add(p);
          }

          return lista;
        }

        public void Create (Produto e)
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = connection;
          cmd.CommandText = @"INSERT INTO Produto VALUES(@nome, @desc, @valor)";

          cmd.Parameters.AddWithValue("@nome", e.Nome);
          cmd.Parameters.AddWithValue("@desc", e.Descricao);
          cmd.Parameters.AddWithValue("@valor", e.Valor);
          
          cmd.ExecuteNonQuery();
        }   


        public void Delete (int id)
        {
          SqlCommand cmd =  new SqlCommand();
          cmd.Connection = connection;
          cmd.CommandText = @"DELETE FROM Produto WHERE IdProduto=@id";
           
            cmd.Parameters.AddWithValue("@id",id);

          cmd.ExecuteNonQuery();
        }

        
        public Produto Read (int id)
        {
          Produto p = null;
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = connection;
          cmd.CommandText = @"SELECT * FROM Produto 
                                  WHERE idProduto = @id";

            cmd.Parameters.AddWithValue("@id", id); 
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
              p = new Produto 
              {
                IdProduto = (int)reader["IdProduto"],
                Nome = (string)reader["Nome"],
                Descricao = (string)reader["Descricao"],
                Valor = (decimal)reader["Valor"]
              };
            }                     
          return p;

        }
        public void Update (Produto e)
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = connection;
          cmd.CommandText = @"UPDATE Produto SET Nome = @nome, Descricao = @desc, Valor = @valor WHERE IdProduto = @id";

          cmd.Parameters.AddWithValue("@nome", e.Nome);
          cmd.Parameters.AddWithValue("@desc", e.Descricao);
          cmd.Parameters.AddWithValue("@valor", e.Valor);
          
          cmd.Parameters.AddWithValue("@id",e.IdProduto);
          cmd.ExecuteNonQuery();
        }   

          
        
    }
}