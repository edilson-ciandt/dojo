using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Banco.Business;
using Banco.Model;

namespace Banco.Portal
{
    public partial class Saque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSacar_Click(object sender, EventArgs e)
        {
            ContaBusiness contaBusiness = new ContaBusiness();
            CaixaBusiness caixaBusiness = new CaixaBusiness();
            Conta conta = contaBusiness.BuscarPorId(int.Parse(txtNumero.Text));

            if (conta == null)
            {
                lblResultadoDoSaque.Text = "Conta Inexistente";
            }

            else if (caixaBusiness.Sacar(conta, int.Parse(txtValor.Text)))
            {
                lblResultadoDoSaque.Text = "Saque efetuado!";
            }

            else
            {
                lblResultadoDoSaque.Text = "Falha ao sacar";
            }

        }
    }
}