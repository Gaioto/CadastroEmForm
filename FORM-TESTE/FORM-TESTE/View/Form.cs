using FORM_TESTE.Model;
using FORM_TESTE.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_TESTE
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            IProdutoAPIService api = new IProdutoAPIService();
            Produto produto = new Produto()
            {
                Codigo = (int)codigo.Value,
                Nome = nome.Text,
                Estoque = (int)estoque.Value,
                Preco = preco.Value
            };

            api.PostProduto(produto);
            LimpaCampos();
        }

        private void atualizarLista_Click(object sender, EventArgs e)
        {
            CarregaProdutos();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CarregaProdutos();
        }

        private void listaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaProdutos.SelectedItems.Count > 0)
            {
                LimpaCampos();
                novoCodigo.Text = listaProdutos.SelectedItems[0].Text;
                novoNome.Text = listaProdutos.SelectedItems[0].SubItems[1].Text;
                novoEstoque.Value = Convert.ToDecimal(listaProdutos.SelectedItems[0].SubItems[2].Text);
                novoPreco.Value = Convert.ToDecimal(listaProdutos.SelectedItems[0].SubItems[3].Text);
            }
            
        }

        private void atualizaProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(novoCodigo.Text))
            {
                Produto produtoAtualizado = new Produto()
                {
                    Codigo = Convert.ToInt32(novoCodigo.Text),
                    Nome = novoNome.Text,
                    Estoque = (int)novoEstoque.Value,
                    Preco = novoPreco.Value
                };
                LimpaCamposAtualiza();
                IProdutoAPIService api = new IProdutoAPIService();
                api.PutProduto(produtoAtualizado);
                CarregaProdutos();
            }
        }

        private void deletarProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(novoCodigo.Text))
            {
                IProdutoAPIService api = new IProdutoAPIService();
                api.DeleteProduto(Convert.ToInt32(novoCodigo.Text));
                LimpaCamposAtualiza();
                CarregaProdutos();  
            }       
        }

        private void CarregaProdutos()
        {
            IProdutoAPIService api = new IProdutoAPIService();
            var produtos = api.GetProdutos();
            listaProdutos.Items.Clear();

            foreach (Produto produto in produtos)
            {
                string[] linha = { produto.Codigo.ToString(), produto.Nome, produto.Estoque.ToString(), produto.Preco.ToString() };
                var produtoLista = new ListViewItem(linha);
                listaProdutos.Items.Add(produtoLista);
            }
        }

        private void LimpaCampos()
        {
            codigo.Value = 0;
            nome.Clear();
            estoque.Value = 0;
            preco.Value = 0.0M;
        }

        private void LimpaCamposAtualiza()
        {
            novoCodigo.Text = "";
            novoNome.Text = "";
            novoEstoque.Value = 0;
            novoPreco.Value = 0.0M;
        }
    }
}
