using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPLabII_CS
{
    class CuentaBancaria
    {
        private DateTime _fechaCreacion;
        private int _numeroCuenta;
        private double _saldo;
        private eTipoCuenta _tipoCuenta;

        private CuentaBancaria()
        {
            _fechaCreacion = DateTime.Now;
        }
        public CuentaBancaria(eTipoCuenta tipoCuenta):this()
        {
            _tipoCuenta = tipoCuenta;
        }
        public CuentaBancaria(eTipoCuenta tipoCuenta, int nroCuenta):this(tipoCuenta)
        {
           _numeroCuenta = nroCuenta;
        }
        public CuentaBancaria(eTipoCuenta tipoCuenta, int nroCuenta, double saldo)
            : this(tipoCuenta, nroCuenta)
        {
            _saldo = saldo;
        }
        public CuentaBancaria(eTipoCuenta tipoCuenta, int nroCuenta, double saldo, DateTime fecha)
            : this(tipoCuenta, nroCuenta, saldo)
        {
            _fechaCreacion = fecha;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo de cuenta: " + _tipoCuenta);
            sb.AppendLine("Nro de cuenta: " + _numeroCuenta);
            sb.AppendLine("Saldo: " + _saldo);
            sb.AppendLine("Fecha de creacion: " + _fechaCreacion);

            return sb.ToString();
        }
        public static string Mostrar(CuentaBancaria cuenta)
        {
            return cuenta.Mostrar();
        }

        public static explicit operator string(CuentaBancaria cuenta)
        {
            return CuentaBancaria.Mostrar(cuenta);
        }

        public static bool operator ==(CuentaBancaria c1, CuentaBancaria c2)//compara dos cuentas por el tipo y nro de cuenta
        {
            if (c1._tipoCuenta == c2._tipoCuenta && c1._numeroCuenta == c2._numeroCuenta)
            {
                return true;
            }
            else {
                return false;
            }
        }
        public static bool operator !=(CuentaBancaria c1, CuentaBancaria c2)//idem anterior
        {
            return !(c1 == c2);
        }

        public static CuentaBancaria operator +(CuentaBancaria c, double importe)//suma al saldo, el importe pasado
        {
            c._saldo += importe;
            return c;
        }//+
        public static double operator +(CuentaBancaria c1, CuentaBancaria c2)//compara ambas cuentas para sumar sus saldos
        {
            if (c1 == c2)
            {
                return c1._saldo + c2._saldo;
            }
            else {
                Console.WriteLine("Las cuentas NO son iguales.");
                return 0;
            }
        }//c+c

        public static bool operator >(CuentaBancaria c, double importe)//compara el saldo de la cuenta con el importe
        {
            if (c._saldo > importe)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//>
        public static bool operator <(CuentaBancaria c, double importe)//idem anterior
        {
            return !(c > importe);
        }//<

        public static CuentaBancaria operator -(CuentaBancaria c, double imp)
        {
            if (c > imp)
            {
                c._saldo -= imp;
                return c;
            }
            else
            {
                Console.WriteLine("Su cuenta no posee saldo suficiente.");
                return c;
            }//-
        }
    }
}
