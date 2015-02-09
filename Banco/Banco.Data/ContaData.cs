using Banco.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Data
{
    public class ContaData:BaseData, IData<Conta>
    {
        public void Inserir(Conta conta)
        {
            Database db = GetDataBaseConnection();
            string sql = "INSERT INTO CONTA (IDCLIENTE, SALDO, SENHA) VALUES (@IDCLIENTE, @SALDO, @SENHA) SET @ID = (SELECT @@IDENTITY)";
            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@IDCLIENTE", System.Data.DbType.Int32, conta.IdCliente);
                db.AddInParameter(cmd, "@SALDO", System.Data.DbType.Decimal, conta.Saldo);
                db.AddInParameter(cmd, "@SENHA", System.Data.DbType.Int32, conta.Senha);
                db.AddOutParameter(cmd, "@ID", System.Data.DbType.Int32, 4);

                db.ExecuteNonQuery(cmd);

                conta.Id =(int)db.GetParameterValue(cmd, "@ID");
            }


        }

        public IEnumerable<Conta> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Conta BuscarPorId(int contaId)
        {
            Database db = GetDataBaseConnection();

            Conta conta = new Conta();
            string sql = "SELECT * FROM CONTA WHERE Id = @Id";
            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@Id", System.Data.DbType.String, contaId);
                DataSet resultado = db.ExecuteDataSet(cmd);

                if (resultado.Tables[0].Rows.Count == 0)
                    return null;

                conta.IdCliente = (int)resultado.Tables[0].Rows[0]["IdCliente"];
                conta.Saldo = (decimal)resultado.Tables[0].Rows[0]["Saldo"];
                conta.Id = (int)resultado.Tables[0].Rows[0]["Id"];
  
            }

            return conta;
        }

        public void Excluir(int contaId)
        {
            Database db = GetDataBaseConnection();

            Conta conta = new Conta();
            string sql = "DELETE FROM CONTA WHERE Id = @Id";
            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@Id", System.Data.DbType.String, contaId);
                db.ExecuteNonQuery(cmd);

            }
        }

        public void Atualizar(Conta objeto)
        {
            throw new NotImplementedException();
        }
    }
}
