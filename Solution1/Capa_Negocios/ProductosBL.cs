using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;
namespace Capa_Negocios
{
    public class ProductosBL
    {
        public List<ProductosBE> ListarProducto()
        {
            ProductosDA obj = new ProductosDA();
            return obj.ListarProducto();
        }
    }
}
