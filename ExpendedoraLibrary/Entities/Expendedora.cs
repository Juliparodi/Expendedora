using ExpendedoraLibrary.Exceptions;
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
            this.capacidad = 10;
            if (encendida.Equals(false))
            {
                throw new MaquinaApagadaException("La maquina se encuentra apagada");
            } else if (this.latas.Any(lata2 => lata2.Codigo.Equals(lata.Codigo)))
            {
                throw new CodigoInvalidoException("El codigo ya existe");
            } else if(this.latas.Count > this.capacidad)
            {
                throw new CapacidadInsuficienteException("La maquina ya esta llena");
            }

            this.Latas.Add(lata);
        }

        public void agregarLatas(List<Lata> latas)
        {
            if (encendida.Equals(false))
            {
                throw new MaquinaApagadaException("La maquina se encuentra apagada");
            }

            this.Latas = latas;
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
            this.encendida = true;

        }

        public bool estaVacia()
        {

        }

        public List<Lata> listarLatas()
        {

        }
    }
}
