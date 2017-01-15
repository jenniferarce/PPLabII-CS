using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPLabII_CS
{
    class Persona
    {
        private CuentaBancaria _cuenta;
        private int _dni;
        private string _nombre;

        public Persona(string nombre, int dni, CuentaBancaria cuenta)
        {
            _nombre = nombre;
            _dni = dni;
            _cuenta = cuenta;
        }
        public Persona(string nombre, int dni, eTipoCuenta tipoCuenta, int nroCuenta)
            : this(nombre, dni, new CuentaBancaria(tipoCuenta, nroCuenta))
        { }
        
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + _nombre);
            sb.AppendLine("DNI: " + _dni);
            sb.Append(CuentaBancaria.Mostrar(_cuenta));

            return sb.ToString();
        }
        public static string Mostrar(Persona per)
        {
            return per.Mostrar();
        }

        public static implicit operator string(Persona per)
        {
            return Persona.Mostrar(per);
        }//implicit

        public static bool operator ==(Persona per, CuentaBancaria c)
        {
            return per._cuenta == c;//reutiliza cod en cuentabancaria
        }
        public static bool operator !=(Persona per, CuentaBancaria c)
        {
            return !(per._cuenta == c);//idem anterior
        }
            
    }
}
