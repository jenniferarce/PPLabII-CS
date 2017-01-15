using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//CUENTA BANCARIA
namespace PPLabII_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria primeraCuenta = new CuentaBancaria(eTipoCuenta.PlazoFijo);
            CuentaBancaria segundaCuenta = new CuentaBancaria(eTipoCuenta.Salario, 123);
            CuentaBancaria terceraCuenta = new CuentaBancaria(eTipoCuenta.CuentaCorriente, 123, 5000);
            CuentaBancaria cuartaCuenta = new CuentaBancaria(eTipoCuenta.CuentaCorriente, 123, 3000);
            
            bool flg = false;
            eTipoCuenta tipo = new eTipoCuenta();
            do
            {
                Console.WriteLine("Elija un tipo de cuenta: 1- Cuenta Corriente, 2- PlazoFijo, 3- Salario");
                int tipoC = int.Parse(Console.ReadLine());
                
                switch (tipoC)
                {
                    case 1:
                        tipo = eTipoCuenta.CuentaCorriente;
                        flg = true;
                        break;
                    case 2:
                        tipo = eTipoCuenta.PlazoFijo;
                        flg = true;
                        break;
                    case 3:
                        tipo = eTipoCuenta.Salario;
                        flg = true;
                        break;
                    default:
                        Console.WriteLine("La cuenta no existe, elija otra opcion.");
                        flg = false;
                        break;
                }
            } while (flg == false);
            CuentaBancaria quintaCuenta = new CuentaBancaria(tipo, 222, 1000);

            /*
             * string aux = "";
             * eTipoCuenta = tipo;
             * Console.WriteLine("Ingrese tipo de cuenta (CuentaCorriente,PlazoFijo o Salario)");
             * aux = Console.ReadLine();
             * tipo = (ETipoCuenta)Enum.Parse(typeof(ETipoCuenta), aux);
             * */

            Persona primeraPersona = new Persona("John", 12345678, segundaCuenta);
            Persona segundaPersona = new Persona("Steve", 78945612, eTipoCuenta.Salario, 126);

            Persona.Mostrar(primeraPersona);
            Persona.Mostrar(segundaPersona);

            if (primeraPersona == segundaCuenta)
            {
                Console.WriteLine("La cuenta (segundaCuenta) le pertenece.");
            }
            else
            {
                Console.WriteLine("Esta cuenta (segundaCuenta) no le pertenece.");
            }//1raP = 2daC
            if (primeraPersona == terceraCuenta)
            {
                Console.WriteLine("La cuenta (terceraCuenta) le pertenece.");
            }
            else
            {
                Console.WriteLine("Esta cuenta (terceraCuenta) no le pertenece.");
            }//1raP = 3rC

            Console.WriteLine((string)cuartaCuenta);
            CuentaBancaria nuevaCuenta = cuartaCuenta + 500;
            Console.WriteLine((string)nuevaCuenta);
            Console.WriteLine((string)cuartaCuenta);
            Console.WriteLine("*************************************");
            double saldoSumado = terceraCuenta + cuartaCuenta;
            double otraSaldoSumado = terceraCuenta + segundaCuenta;
            Console.WriteLine("{0} {1}", saldoSumado, otraSaldoSumado);
            if (quintaCuenta > 1000)
                Console.WriteLine("La quintaCuenta tiene más de $1000");
            else
                Console.WriteLine("La quintaCuenta no tiene más de $1000");
            Console.WriteLine((string)quintaCuenta);
            quintaCuenta = quintaCuenta - 500;
            Console.WriteLine((string)quintaCuenta);

            Console.ReadKey();

        }
    }
}