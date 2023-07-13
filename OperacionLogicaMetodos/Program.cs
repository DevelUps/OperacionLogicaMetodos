using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionLogicaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // variables 
           int opcion;
           decimal r ; // almacena el valor devuelto por returm
           decimal num1Ar, num2Ar; //argumentos para enviar una compia de su valor a multiplicar
            


            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.Write("Escoge una opcion:  ");

                // Pedimos una opcion
                opcion = Convert.ToInt16(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));
            

            // hacemos la operacion segun la operacion con un switch

            switch (opcion)
            {
                case 1:
                    // llamamos al metodo sumar()
                    Sumar();
                    
                    break;
                case 2:
                    // variable
                    r = Restar(); // aignamos "r" el valor devuelto por "returno"

                    // mostramos el resultado, con la informacion de "r"
                    Console.WriteLine("el resultado es {0}:  ", r) ;

                    break;
                case 3:
                    // Pedimos el valor de ambos numeros
                    num1Ar = IngresarNumero("Ingresa el primer numero: ");
                    num2Ar = IngresarNumero("Ingresa el primer numero: ");

                    // llamamos al metodo multiplicacion
                    Multiplicar(num1Ar, num2Ar);
                    
                    break;
                case 4:
                    // Pedimos el valor de ambos numeros
                    Console.Write("Ingresa el primer numero:  ");
                    num1Ar = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Ingresa el Segundo numero:  ");
                    num2Ar = Convert.ToDecimal(Console.ReadLine());

                    r = Dividir(num1Ar, num2Ar);

                   
                    // mostramos el resultado, con la informacion de "r"
                    Console.WriteLine("el resultado de la division  es {0}:  ", r);

                    break;
            }
        } // cierre de main

        // [Modificador][tipo][Identificador][parametros]
        // metodo sin parametro y sin tipo

        static void Sumar()
        {
            // variables del metodo sumar
            decimal num1, num2, resultado;
            
            // Pedimos el valor de ambos numeros
            Console.Write("Ingresa el primer numero:  ");
            num1 = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("Ingresa el Segundo numero:  ");
            num2 = Convert.ToDecimal(Console.ReadLine());
            
            // Operacion
            resultado = num1 + num2;

            // Mostramos el resultado

            Console.WriteLine("{0} + {1}  = {2}",num1,num2, resultado);
        }
        // [Modificador][tipo][Identificador][parametros]
        // metodo con tipo
        static decimal  Restar()
        {
            // variables del metodo sumar
            decimal num1, num2, resultado;

            // Pedimos el valor de ambos numeros
            Console.Write("Ingresa el primer numero:  ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el Segundo numero:  ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            // Operacion
            resultado = num1 -  num2;

            // devolvemos un tipo al autor del resultado
            return (resultado);
           
        }
        // [Modificador][tipo][Identificador][parametros]
        // metodo con parametrs
        static void Multiplicar(decimal num1pa, decimal num2pa)
        {

        
            // variables del metodo sumar
            decimal  resultado;

            // multiplicaciones que envian los argumentos

            resultado = num1pa * num2pa;

            Console.WriteLine("{0} * {1}  = {2}", num1pa, num2pa, resultado);

        }
        // [Modificador][tipo][Identificador][parametros]
        static decimal Dividir(decimal num1pa, decimal num2pa)
        {


            // variables del metodo sumar
            decimal resultado;
            
            if (num2pa != 0) 
            {
            resultado = num1pa / num2pa;

            }
            else
            {
                Console.WriteLine("No es posibble dividir entre 0 ");
                resultado = 0;
            }
            // multiplicaciones que envian los argumentos
            return resultado;
            

            

        }
        // [Modificador][tipo][Identificador][parametros]
        static decimal IngresarNumero(string peticion)
        {
            // Es una variable local al metodo
            decimal numero;

            // peridmos el valor segun corresponda
            Console.Write(peticion);
            //convertimos y asignamos
            numero = Convert.ToDecimal(Console.ReadLine());
            // devolvemos al valor tipo decimal
            return numero;
        }



    }
}
