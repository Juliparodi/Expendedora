using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraLibrary.Entities
{
    public class Expendedora
    {
        List<Lata> latas;
        string proveedor;
        int capacidad;
        double dinero;
        bool encendida;

        public Expendedora() { }
        public Expendedora(List<Lata> latas, string proveedor, int capacidad, double dinero, bool encendida)
        {
            this.Latas = latas;
            this.Proveedor = proveedor;
            this.Capacidad = capacidad;
            this.Dinero = dinero;
            this.Encendida = encendida;
        }

        public string Proveedor { get => proveedor; set => proveedor = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public double Dinero { get => dinero; set => dinero = value; }
        public bool Encendida { get => encendida; set => encendida = value; }
        internal List<Lata> Latas { get => latas; set => latas = value; }

        public void agregarLata(Lata lata)
        {

        }

        public Lata extraerLata(string proveedor, double dinero)
        {

        }

        public string getBalance()
        {

        }

        public int getCapacidadRestante()
        {

        }

        public void encenderMaquina()
        {

        }

        public bool estaVacia()
        {

        }

        public List<Lata> listarLatas()
        {

        }
    }
}
