using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraLibrary.Entities
{
   public class Lata
    {
        string codigo;
        string nombre;
        string sabor;
        double precio;
        double volumen;
        int cantidad;

        public Lata() { }

        public Lata(string codigo, string nombre, string sabor, double precio, double volumen, int cantidad)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Sabor = sabor;
            this.Precio = precio;
            this.Volumen = volumen;
            this.Cantidad = cantidad;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Sabor { get => sabor; set => sabor = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Volumen { get => volumen; set => volumen = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public void getPrecioPorLitro()
        {

        }

        public string toString()
        {
            return String.Format("lata con nombre: {0}, codigo: {1} , sabor {2} , precio: {3}" +
                "volumen: {4} , cantidad: {5} ", this.nombre, this.codigo, this.sabor, this.precio, this.volumen, this.cantidad);
        }
    }
}
