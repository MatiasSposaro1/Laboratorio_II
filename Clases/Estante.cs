using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02___La_estantería.Clases
{
    public class Estante
    {
        private Producto[] _productos;
        private int _ubicacion;

        private Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this._ubicacion = ubicacion;
        }

        public Producto[] Productos
        {
            get { return _productos; }
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto p in e.Productos)
            {
                sb.AppendLine(Producto.MostrarProducto(p));
            }
            return sb.ToString();//error aca
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool isAlready = false;
            foreach (Producto p2 in e.Productos)
            {
                if (p == p2) //error aca
                {
                    isAlready = true;
                    break;
                }
            }
            return isAlready;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool canAdd = false;
            if (!(e == p)) //error aca
            {
                int size = e.Productos.Length;
                for (int i = 0; i < size; i++)
                {
                    if (e.Productos[i] is null)
                    {
                        e.Productos[i] = p;
                        canAdd = true;
                        break;
                    }
                }
            }

            return canAdd;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                int cont = 0;
                foreach (Producto p2 in e.Productos)
                {
                    if (p2 == p)
                    {
                        e.Productos[cont] = null;
                    }
                    cont++;
                }
            }
            return e;
        }
    }
}
