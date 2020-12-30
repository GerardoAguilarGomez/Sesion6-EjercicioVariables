using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class milestone1
    {
        public void Variables()
        {

            //FASE 1
            string Nombre = "Gerardo";
            string Apellido1 = "Aguilar";
            string Apellido2 = "Gómez";

            int Dia = 30;
            int Mes = 12;
            int Año = 2020;

            Console.WriteLine(Apellido1 + " "+Apellido2+", "+Nombre);
            Console.WriteLine(Dia + "/" + Mes + "/" + Año);

            //FASE 2
            int AñoInicial = 1948;
            int Frecuencia = 4;
            int AñoNacimiento = 1984;
            int Resultado = 0;
            

            int A = AñoInicial;
            while (A<=AñoNacimiento)
            {
                Resultado++;
                A = A + Frecuencia;
            }

            Console.WriteLine("De {0} a {1} hay {2} años bisiestos", AñoInicial, AñoNacimiento, Resultado);

            //FASE3
            string Bisiesto = " SI es año bisiesto";
            string NoBisiesto = " NO es año bisiesto";
            bool Saber = true;
            int Sumador = AñoInicial;

            for (int i=AñoInicial;i<=AñoNacimiento;i++) {
                
                if(i==Sumador){
                    Saber = true;
                    Sumador = Sumador + Frecuencia;
                }
                else
                {
                    Saber = false;
                }
                if (Saber == true)
                {
                    Console.WriteLine(i + Bisiesto);
                }
                else
                {
                    Console.WriteLine(i + NoBisiesto);
                }
            }

            //FASE 4
            string NombreCompleto = "Gerardo Aguilar Gómez";
            string FechaNacimiento = "7/6/1984";

            Console.WriteLine("Mi nombre es {0}",NombreCompleto);
            Console.WriteLine("La fecha de mi nacimiento es {0}", FechaNacimiento);

            for(int i = AñoInicial; i <= AñoNacimiento; i = i + Frecuencia)
            {
                if (i == AñoNacimiento)
                {
                    Console.WriteLine("Mi año de nacimiento es bisiesto");
                }
                else
                {

                }
            }
        }
    }
}
