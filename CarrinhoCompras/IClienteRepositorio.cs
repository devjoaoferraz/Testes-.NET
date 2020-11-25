using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoCompras {
    public interface IClienteRepositorio {
        IList<Cliente> BuscarTodos();
        Cliente FindByNome(string clienteNome);
        Cliente BuscaPorId(int clienteId);
        bool Salvar(Cliente cliente);
    }
}
