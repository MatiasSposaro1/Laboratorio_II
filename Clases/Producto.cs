using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02___La_estantería.Clases
{
     public class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            _codigoDeBarra = codigoDeBarra;
            _marca = marca;
            _precio = precio;
        }

        #region GETTERS
        public string GetMarca()
        {
            return _marca;
        } 

        public float GetPrecio()
        {
            return _precio;
        }

        #endregion
        #region SOBRECARGA
        public static explicit operator string(Producto p)
        {
            return p._codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p._marca == marca;
        }
        public static bool operator != (Producto p,string marca)
        {
            return !(p._marca == marca);
        }


        public static bool operator == (Producto p1, Producto p2)
        {
            return p1 == p2;
        }
        
        public static bool operator != (Producto p1,Producto p2)
        {
            return !(p1 == p2);
        }
        #endregion

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de Barra:{p._codigoDeBarra}|Marca:{p._marca}      Precio:${p._precio}");
            sb.AppendLine("_____________");

            return sb.ToString();
        }

    }
}
