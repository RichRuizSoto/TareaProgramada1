using Inventario.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.LogicaDeNegocio.Inventario.ListarInventario
{
	public interface IListarInventarioLN
	{
		List<InventarioDto> Obtener();
	}
}
