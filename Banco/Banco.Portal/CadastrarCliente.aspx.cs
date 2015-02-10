using Banco.Business;
using Banco.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banco.Portal
{
    public partial class CadastrarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBusiness business = new ClienteBusiness();
            cliente.Cpf = txtCpf.Text;
            cliente.Nome = txtNome.Text;
            cliente.DataDeNascimento = cldData.SelectedDate;
            cliente.Endereco = txtEndereco.Text;

            business.Inserir(cliente);

            lblConfirmacao.ForeColor = Color.Red;
            lblConfirmacao.Text = "ERRO AO INSERIR CLIENTE";

            if (cliente.Id != 0)
            {

                Conta conta = new Conta();
                conta.IdCliente = cliente.Id;
                conta.Saldo = 5000;
                conta.Senha = "1234";

                ContaBusiness contaBusiness = new ContaBusiness();
                contaBusiness.Inserir(conta);
                if (conta.Id != 0)
                    {
                        Cartao cartao = new Cartao();
                        cartao.IdCliente = cliente.Id;
                        cartao.IdConta = conta.Id;
                        cartao.LimiteCartao = 10000;

                        CartaoBusiness cartaoBusiness = new CartaoBusiness();
                        cartaoBusiness.Inserir(cartao);

                        if (cartao.Id != 0)
                        {

                            lblConfirmacao.ForeColor = Color.Green;
                            lblConfirmacao.Text = "CLIENTE CADASTRADO COM SUCESSO";
                        }

                    }

            }

        }
    }
}