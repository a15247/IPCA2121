using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService1.Entidades;

namespace WcfService1.Servicos
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Clientes" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Clientes.svc ou Clientes.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Clientes : IClientes
    {
        private List<Cliente> clientes;
        public Clientes()
        {
            clientes = new List<Cliente>
            {
                new Cliente {Codigo = 1, Nome = "Manuel"},
                new Cliente {Codigo = 2, Nome = "Maria"},
                new Cliente {Codigo = 3, Nome = "Mariana"}
            };
        }

        //retorna o cliente atraves do codigo pedido
        public Cliente Get(int codigo)
        {
            return clientes.FirstOrDefault(c => c.Codigo == codigo);
        }

        //retorna a lista de clientes
        public List<Cliente> GetAll()
        {
            return this.clientes;
        }

        //insere o cliente na lista
        public void Set(Cliente cliente)
        {
            this.clientes.Add(cliente);
        }
    }
}
