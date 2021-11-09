using Servidor1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servidor1.Servicos
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "ICarros" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface ICarros
    {
        [OperationContract]
        Carro Get(int codigo);

        [OperationContract]
        void Set(Carro carro);

        [OperationContract]
        List<Carro> GetAll();
    }
}
