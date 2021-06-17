using API_TESTE.Models;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_TESTE.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            DirectoryInfo d = new DirectoryInfo(@"ProdutosJson/");
            FileInfo[] Files = d.GetFiles("*.json");
            foreach (FileInfo file in Files)
            {
                if (file.Name.Contains("EXCLUIDO"))
                    continue;
                using (StreamReader r = new StreamReader(@"ProdutosJson/" + file.Name))
                {
                    string produtoJson = r.ReadToEnd();             
                    produtos.Add(serializer.Deserialize<Produto>(produtoJson));
                }
            }

            return produtos;
        } 

        [HttpGet("{codigo}")]
        public Produto GetProduto(int codigo)
        {
            Produto produto;
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string caminhoJson = string.Format(@"ProdutosJson/{0}.json", codigo.ToString());

            var json = System.IO.File.ReadAllText(caminhoJson);

            using (StreamReader r = new StreamReader(caminhoJson))
            {
                string produtoJson = r.ReadToEnd();
                produto = serializer.Deserialize<Produto>(produtoJson);
            }

            return produto;
        }

        [HttpPost]
        public void PostProduto(Produto produto)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            var produtoJson = serializer.Serialize(produto);

            string caminhoJson = string.Format(@"ProdutosJson/{0}.json", produto.Codigo.ToString());

            System.IO.File.WriteAllText(caminhoJson, produtoJson);
        }

        [HttpPut("{codigo}")]
        public void PutProduto(int codigo, Produto produto)
        {
            Produto produtoAtualizar = GetProduto(codigo);

            produtoAtualizar.Estoque = produto.Estoque;
            produtoAtualizar.Preco = produto.Preco;

            PostProduto(produtoAtualizar);
        }

        // Ideia de exclusão lógica
        [HttpDelete("{codigo}")]
        public void DeleteProduto(int codigo)
        {
            string caminhoJson = string.Format(@"ProdutosJson/{0}.json", codigo.ToString());
            string jsonExcluido = string.Format(@"ProdutosJson/EXCLUIDO{0}.json", codigo.ToString());
            System.IO.File.Copy(caminhoJson, jsonExcluido);
            System.IO.File.Delete(caminhoJson);
        }
    }
}
