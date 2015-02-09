using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace Banco.Data
{
    public class ClienteData : IData<Cliente>
    {

        private Database db = new DatabaseProviderFactory().Create("DataBase");

        public void Inserir(Cliente cliente)
        {
            string sql = "INSERT INTO CLIENTE (Cpf, Nome, Endereco, DataDeNascimento) values (@Cpf, @Nome, @Endereco, @DataDeNascimento) set @id = (Select @@identity)";
            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@Cpf", System.Data.DbType.String, cliente.Cpf);
                db.AddInParameter(cmd, "@Nome", System.Data.DbType.String, cliente.Nome);
                db.AddInParameter(cmd, "@Endereco", System.Data.DbType.String, cliente.Endereco);
                db.AddInParameter(cmd, "@DataDeNascimento", System.Data.DbType.DateTime, cliente.DataDeNascimento);
                db.AddOutParameter(cmd, "@Id", System.Data.DbType.Int32, 4);

                db.ExecuteNonQuery(cmd);

                cliente.Id = (int)db.GetParameterValue(cmd, "@Id");

            }
        }

        public IEnumerable<Cliente> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int clienteId)
        {
            Cliente cliente = new Cliente();
            string sql = "SELECT * FROM CLIENTE WHERE Id = @Id";
            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@Id", System.Data.DbType.String, clienteId);
                DataSet resultado = db.ExecuteDataSet(cmd);

                if (resultado.Tables[0].Rows.Count == 0)
                    return null;

                cliente.Id = (int)resultado.Tables[0].Rows[0]["Id"];
                cliente.Nome = (String)resultado.Tables[0].Rows[0]["Nome"];
                cliente.Cpf = (String)resultado.Tables[0].Rows[0]["Cpf"];
                cliente.Endereco = (String)resultado.Tables[0].Rows[0]["Endereco"];
                cliente.DataDeNascimento = (DateTime)resultado.Tables[0].Rows[0]["DataDeNascimento"];
            }

            return cliente;
        }

        public void Excluir(int clienteId)
        {

            string sql = "DELETE FROM CLIENTE WHERE Id = @Id";
            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@Id", System.Data.DbType.String, clienteId);
                db.ExecuteNonQuery(cmd);
            }

        }

        public void Atualizar(Cliente cliente)
        {
            string sql = "UPDATE CLIENTE SET Nome = @Nome, Cpf = @Cpf, Endereco = @Endereco, DataDeNascimento = @DataDeNascimento WHERE Id = @Id";
            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@Nome", System.Data.DbType.String, cliente.Nome);
                db.AddInParameter(cmd, "@Endereco", System.Data.DbType.String, cliente.Endereco);
                db.AddInParameter(cmd, "@DataDeNascimento", System.Data.DbType.String, cliente.DataDeNascimento);
                db.AddInParameter(cmd, "@Cpf", System.Data.DbType.String, cliente.Cpf);
                db.AddInParameter(cmd, "@Id", System.Data.DbType.String, cliente.Id);

                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
