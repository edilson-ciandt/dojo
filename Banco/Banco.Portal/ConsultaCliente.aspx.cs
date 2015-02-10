using Banco.Business;
using Banco.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banco.Portal
{
    public partial class ConsultaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            atualizarPagina();
        }


        public void atualizarPagina()
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();

            List<Cliente> clientes = clienteBusiness.BuscarTodos().ToList();
            Dictionary<string, string> dicClientes = new Dictionary<string, string>();

            DataTable dtTable = new DataTable();
            dtTable.Columns.Add("Id");
            dtTable.Columns.Add("Nome");
            dtTable.Columns.Add("Cpf");
            dtTable.Columns.Add("Saldo");
            foreach (Cliente c in clientes)
            {
                DataRow dr = dtTable.NewRow();
                dr["Id"] = c.Id;
                dr["Nome"] = c.Nome;
                dr["Cpf"] = c.Cpf;
                dr["Saldo"] = String.Format("{0:0.##}", c.Conta.Saldo);

                dtTable.Rows.Add(dr);


            }
            grvClientes.DataSource = dtTable.DefaultView;
            grvClientes.DataBind();
        }

        protected void grvClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvClientes.PageIndex = e.NewPageIndex;
            atualizarPagina();
        }

    }
}