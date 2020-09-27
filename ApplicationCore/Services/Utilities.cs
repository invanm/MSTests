using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class Utilities
    {
        public int ContarDivisores(int numero)
        {
            var contador = 0;
            for (int i = 1; i < numero; i++)
                if (numero % i == 0)
                    contador++;

            return contador;
        }

        public class Product

        {
            public int Code { get; set; }
            public string Desc { get; set; }
            public double Value { get; set; }

        }

        public double ObtenerValorProducto(int codigo)

        {
            var listProducts = new List<Product>()

            {
                new Product{ Code = 1250, Desc = "MOUSE 3 BOTONES", Value = 15500 },
                new Product{ Code = 1260, Desc = "IMPRESORA LASER", Value = 678000 },
                new Product{ Code = 1270, Desc = "MEMORIA USB 20 GB", Value = 35000 },
                new Product{ Code = 1280, Desc = "DISCO DURO 500 GB", Value = 180000 },
                new Product{ Code = 1290, Desc = "MONITOR 14 PULGADAS", Value = 280000 }

                };
            var product = listProducts.Where(x => x.Code == codigo).FirstOrDefault();
            return product.Value;

        }

    }
}
