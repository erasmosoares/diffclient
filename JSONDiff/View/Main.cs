using Model.JSONDiff;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONDiff
{
    public partial class Tool : Form
    {
        string URI = "";
        int codigoProduto = 1;

        public Tool()
        {
            InitializeComponent();
        }

        private async void GetAllProdutos()
        {
            URI = txtURI.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        //clienteUri = response.Headers.Location;
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<JSONFile[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }

        private void btnGetStoredFiles_Click(object sender, EventArgs e)
        {
            GetAllProdutos();
        }


        //private async void GetProdutoById(int codProduto)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        BindingSource bsDados = new BindingSource();
        //        URI = txtURI.Text + "/" + codProduto.ToString();

        //        HttpResponseMessage response = await client.GetAsync(URI);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var ProdutoJsonString = await response.Content.ReadAsStringAsync();
        //            bsDados.DataSource = JsonConvert.DeserializeObject<Produto>(ProdutoJsonString);
        //            dgvDados.DataSource = bsDados;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Falha ao obter o produto : " + response.StatusCode);
        //        }
        //    }
        //}

        //private async void AddProduto()
        //{
        //    URI = txtURI.Text;
        //    Produto prod = new Produto();
        //    //prod.Id = codProduto;
        //    prod.Nome = "NoteBook Lenovo";
        //    prod.Categoria = "Notebooks";
        //    prod.Preco = 1200.00M;

        //    using (var client = new HttpClient())
        //    {
        //        var serializedProduto = JsonConvert.SerializeObject(prod);
        //        var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
        //        var result = await client.PostAsync(URI, content);
        //    }
        //    GetAllProdutos();
        //}

        //private async void UpdateProduto(int codProduto)
        //{
        //    URI = txtURI.Text;
        //    Produto prod = new Produto();
        //    prod.Id = codProduto;
        //    prod.Nome = "NoteBook Apple";
        //    prod.Categoria = "Notebooks";
        //    prod.Preco = 9900.00M; // atualizando o preço do produto

        //    using (var client = new HttpClient())
        //    {
        //        HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + prod.Id, prod);
        //        if (responseMessage.IsSuccessStatusCode)
        //        {
        //            MessageBox.Show("Produto atualizado");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Falha ao atualizar o produto : " + responseMessage.StatusCode);
        //        }
        //    }
        //    GetAllProdutos();
        //}


        //private async void DeleteProduto(int codProduto)
        //{
        //    URI = txtURI.Text;
        //    int ProdutoID = codProduto;
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(URI);
        //        HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, ProdutoID));
        //        if (responseMessage.IsSuccessStatusCode)
        //        {
        //            MessageBox.Show("Produto excluído com sucesso");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Falha ao excluir o produto  : " + responseMessage.StatusCode);
        //        }
        //    }
        //    GetAllProdutos();
        //}
    }
}
