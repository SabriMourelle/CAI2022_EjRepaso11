using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio XI
            //Crear una aplicación que, cuando el usuario ingrese un nombre, un apellido y la edad en
            //un mismo input(en cualquier orden), indique cuál es cada uno.
            //Por ejemplo, el usuario ingresa “26 Suyai Pecoraro”, el programa mostrará por pantalla
            //“Nombre: Suyai, Apellido: Pecoraro, Edad: 26”. 

            string nombre;
            string apellido;
            string ingreso;
            string numero="";
            string sinNumeros;
            int edad=0;
            char[] delimitadores = { ' ', ',' };
            
            Console.WriteLine("Ingrese su nombre, apellido y edad");
            ingreso = Console.ReadLine();

            for (int i = 0; i < ingreso.Length; i++)
            {
                if (char.IsDigit(ingreso[i]))
                {
                    numero += ingreso[i];
                }
            }
            if (numero.Length > 0)
            {
                edad = int.Parse(numero);
            }

            sinNumeros = ingreso.Trim(new Char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'});
       
            string[] palabras = sinNumeros.Split(delimitadores);

            if(palabras.Length<2)
            {
                nombre = palabras[0];
                apellido = palabras[1];
            }
            else
            {
                //si ingresa primero la edad, me queda un espacio en el primer lugar del array
                nombre = palabras[1];
                apellido = palabras[2];
            }
            
            Console.WriteLine("Nombre: " + nombre + "Apellido: " + apellido + "Edad: " + edad);
            Console.ReadKey();
        }
    }
}
