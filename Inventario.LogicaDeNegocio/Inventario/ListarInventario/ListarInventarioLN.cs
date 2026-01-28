using Inventario.Abstracciones.LogicaDeNegocio.Inventario.ListarInventario;
using Inventario.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaDeNegocio.Inventario.ListarInventario
{
	public class ListarInventarioLN: IListarInventarioLN
	{
		public ListarInventarioLN() { }

		public List<InventarioDto> Obtener()
		{
			List<InventarioDto> laListaDeInventario = new List<InventarioDto>();
			laListaDeInventario.Add(ObtenerObjeto());
			return laListaDeInventario;
		}

		private InventarioDto ObtenerObjeto()
		{
			return new InventarioDto { 
			Anio = 2025,
			Cantidad = 5,
			CodigoDelRepuesto = "0001",
			Estado = true,
			FechaDeModificacion = DateTime.Now,
			FechaDeRegistro = DateTime.Now,
			MarcaDelRepuesto = "KYB",
			Modelo = "Corolla",
			NombreDelRepuesto = "Compensador",
			Vehiculo = "Toyota"
			};
		}
	}
}
