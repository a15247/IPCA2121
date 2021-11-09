using System;
using System.Collections.Generic;
using ClientService;

namespace Simular_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesClient client = new();
            
            List<Cliente> clientes;

            clientes = client.GetAllAsync().Result;

            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"{cliente.Nome}\t{cliente.Codigo}");
            }
            client.Close();

        }
    }
}
