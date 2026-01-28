using Inventario.Abstracciones.LogicaDeNegocio.Inventario.ListarInventario;
using Inventario.Abstracciones.ModelosParaUI;
using Inventario.LogicaDeNegocio.Inventario.ListarInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.UI.Controllers
{
    public class InventarioController : Controller
    {
        IListarInventarioLN _listarInventario;
        public InventarioController()
        {
            _listarInventario = new ListarInventarioLN();

		}


		// GET: Inventario
		public ActionResult ListarInventario()
        {
            List<InventarioDto> laListaDeInventario = _listarInventario.Obtener();
			return View(laListaDeInventario);
        }

        // GET: Inventario/Details/5
        public ActionResult DetallesInventario()
        {
			InventarioDto elInventario = new InventarioDto { Vehiculo = "Toyota" };
			return View(elInventario);
        }

        // GET: Inventario/Create
        public ActionResult CrearInventario()
        {
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        public ActionResult CrearInventario(InventarioDto elInventarioCreado)
        {
            try
            {
				if (elInventarioCreado.archivo != null && elInventarioCreado.archivo.ContentLength > 0)
				{
					// Convertir el archivo a un arreglo de bytes
					byte[] archivoBytes;
					using (var memoriaStream = new System.IO.MemoryStream())
					{
						elInventarioCreado.archivo.InputStream.CopyTo(memoriaStream);
						archivoBytes = memoriaStream.ToArray();
					}

					// Convertir el archivo a base64
					string base64String = Convert.ToBase64String(archivoBytes);
				}

				return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult EditarInventario()
        {
			InventarioDto elInventario = new InventarioDto { Vehiculo = "Toyota"};
			return View(elInventario);
		}

        // POST: Inventario/Edit/5
        [HttpPost]
        public ActionResult EditarInventario(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Delete/5
        public ActionResult EliminarInventario()
        {
			InventarioDto elInventario = new InventarioDto();
			return View(elInventario);
		}

        // POST: Inventario/Delete/5
        [HttpPost]
        public ActionResult EliminarInventario(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
