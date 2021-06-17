using System.Collections.Generic;
using FORM_TESTE.Model;
using RestSharp;
using Nancy.Json;

namespace FORM_TESTE.Services
{
    public class IProdutoAPIService
    {
        //TODO
        public IEnumerable<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            RestClient restClient = new RestClient("https://localhost:44372/api/Produto/GetProdutos");
            RestRequest restRequest = new RestRequest(Method.GET);
            var restResponse = restClient.Execute<List<Produto>>(restRequest);

            foreach(Produto produto in restResponse.Data)
            {
                produtos.Add(produto);
            }

            return produtos;
        }

        public Produto GetProduto(int codigo)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            RestClient restClient = new RestClient(string.Format(@"https://localhost:44372/api/Produto/GetProduto/{0}", codigo.ToString()));
            RestRequest restRequest = new RestRequest(Method.GET);
            IRestResponse restResponse = restClient.Execute(restRequest);

            Produto produto = serializer.Deserialize<Produto>(restResponse.Content);

            return produto;
        }

        public void PostProduto(Produto produto)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            RestClient restClient = new RestClient("https://localhost:44372/api/Produto/PostProduto");
            RestRequest restResquest = new RestRequest(Method.POST);
            restResquest.AddJsonBody(serializer.Serialize(produto));
            IRestResponse restResponse = restClient.Execute(restResquest);           
        }

        //TODO PUT
        public void PutProduto(Produto produto)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            RestClient restClient = new RestClient(string.Format(@"https://localhost:44372/api/Produto/PutProduto/{0}",produto.Codigo.ToString()));
            RestRequest restResquest = new RestRequest(Method.PUT);
            restResquest.AddJsonBody(serializer.Serialize(produto));
            IRestResponse restResponse = restClient.Execute(restResquest);
        }

        public void DeleteProduto(int codigo)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            RestClient restClient = new RestClient(string.Format(@"https://localhost:44372/api/Produto/DeleteProduto/{0}", codigo.ToString()));
            RestRequest restResquest = new RestRequest(Method.DELETE);
            IRestResponse restResponse = restClient.Execute(restResquest);
        }
    }
}
