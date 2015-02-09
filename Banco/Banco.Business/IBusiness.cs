using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
    public interface IBusiness<T>
    {
        void Inserir(T objeto);
        
        IEnumerable<T> BuscarTodos();
        
        T BuscarPorId(int id);
        
        void Excluir(int id);

        void Atualizar(T objeto);

        bool Verificar(T objeto);
    }
}
