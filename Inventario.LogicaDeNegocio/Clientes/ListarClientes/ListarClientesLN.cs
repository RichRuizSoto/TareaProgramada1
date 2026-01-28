using Inventario.Abstracciones.LogicaDeNegocio.Clientes.ListarClientes;
using Inventario.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaDeNegocio.Clientes.ListarClientes
{
    public class ListarClientesLN : IListarClientesLN
    {
        public List<ClienteDto> Obtener()
        {
            return new List<ClienteDto>
            {
                new ClienteDto
                {
                    IdCliente = 1,
                    NombreCompleto = "Richard Ruiz",
                    Identificacion = "4-444-444",
                    Correo = "richard@email.com",
                    Telefono = "88888888",
                    Estado = true,
                    FechaRegistro = DateTime.Now
                }
            };
        }
    }
}
