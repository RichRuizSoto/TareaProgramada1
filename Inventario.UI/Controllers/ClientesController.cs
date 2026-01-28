using Inventario.Abstracciones.LogicaDeNegocio.Clientes.ListarClientes;
using Inventario.Abstracciones.ModelosParaUI;
using Inventario.LogicaDeNegocio.Clientes.ListarClientes;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Inventario.UI.Controllers
{
    public class ClientesController : Controller
    {
        IListarClientesLN _listarClientes;

        public ClientesController()
        {
            _listarClientes = new ListarClientesLN();
        }

        public ActionResult ListarClientes()
        {
            List<ClienteDto> lista = _listarClientes.Obtener();
            return View(lista);
        }

        public ActionResult DetallesCliente()
        {
            ClienteDto cliente = new ClienteDto { NombreCompleto = "Juan Pérez" };
            return View(cliente);
        }

        public ActionResult CrearCliente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearCliente(ClienteDto cliente)
        {
            return RedirectToAction("ListarClientes");
        }

        public ActionResult EditarCliente()
        {
            ClienteDto cliente = new ClienteDto { NombreCompleto = "Juan Pérez" };
            return View(cliente);
        }

        [HttpPost]
        public ActionResult EditarCliente(ClienteDto cliente)
        {
            return RedirectToAction("ListarClientes");
        }

        public ActionResult EliminarCliente()
        {
            return View(new ClienteDto());
        }

        [HttpPost]
        public ActionResult EliminarCliente(int id)
        {
            return RedirectToAction("ListarClientes");
        }
    }
}
