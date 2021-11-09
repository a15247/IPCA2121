using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService1.Entidades;

namespace WcfService1.Servicos
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IClientes" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IClientes
    {

        //Sem o OperationContract os metodos não são reconhecidos futuramente
        [OperationContract]
        Cliente Get(int codigo);

        [OperationContract]
        void Set(Cliente cliente);
        
        [OperationContract]
        List<Cliente> GetAll();


    }
}
