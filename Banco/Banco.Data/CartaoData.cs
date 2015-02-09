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
    public class CartaoData : IData<Cartao>
    {

        private Database db = new DatabaseProviderFactory().Create("DataBase");

        public void Inserir(Cartao cartao)
        {
        
            string sql = "INSERT INTO Cartao (IdCliente, IdConta, Limite) values (@IdCliente, @IdConta, @Limite) set @id = (Select @@identity)";
            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@IdCliente", System.Data.DbType.Int32, cartao.IdCliente);
                db.AddInParameter(cmd, "@IdConta", System.Data.DbType.Int32, cartao.IdConta);
                db.AddInParameter(cmd, "@Limite", System.Data.DbType.Int32, cartao.LimiteCartao);
                db.AddOutParameter(cmd, "@Id", System.Data.DbType.Int32, 4);


                db.ExecuteNonQuery(cmd);

                cartao.Id = (int)db.GetParameterValue(cmd, "@Id");

            }
        }

        public IEnumerable<Cartao> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Cartao BuscarPorId(int cartaoId)
        {
            string sql = "SELECT * FROM Cartao WHERE Id = @Id";
            Cartao cartao = null;
            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@Id", System.Data.DbType.String, cartaoId);
                DataSet resultado = db.ExecuteDataSet(cmd);

                if (resultado.Tables[0].Rows.Count == 0)
                    return null;


                cartao = new Cartao();
                cartao.IdCliente = (int)resultado.Tables[0].Rows[0]["IdCliente"];
                cartao.IdConta = (int)resultado.Tables[0].Rows[0]["IdConta"];
                cartao.LimiteCartao = Convert.ToDouble(resultado.Tables[0].Rows[0]["Limite"]);
                cartao.Id = (int)resultado.Tables[0].Rows[0]["Id"];
        
            }

            return cartao;
        }

        public void Excluir(int cartaoId)
        {

            string sql = "DELETE FROM CARTAO WHERE Id = @Id";
            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@Id", System.Data.DbType.Int32, cartaoId);
                db.ExecuteNonQuery(cmd);
            }

        }

        public void Atualizar(Cartao cartao)
        {
            throw new NotImplementedException();
        }
    }
}
