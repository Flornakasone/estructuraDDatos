using System;

namespace ej_primeraclase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios EDDatos");
           

            //EJERCICIO 1
            int resultado1 = 200 + 56;
            Console.WriteLine("Ej 1: {0}", resultado1);
           

            //EJERCICIO 2
            int resultado2 = 13 * 12;
            Console.WriteLine("Ej 2: {0}", resultado2);
            

            //EJERCICIO 3
            int resultado3 = 321 - 213;
            Console.WriteLine("Ej 3: {0}", resultado3);


            //EJERCICIO 4
            int resultado4 = (20 + 5) % 3;
            Console.WriteLine("Ej 4: {0}", resultado4);


            //EJERCICIO 5
            int numG = 12;
            int numH = 102;
            int resultado5 = numG * numH;
            Console.WriteLine("Ej 5: {0}", resultado5);


            //EJERCICIO 6
            int numI = 200;
            int numJ = 1111;
            int resultado6 = numI * numJ;
            Console.WriteLine("Ej 6: {0}", resultado6);


            //EJERCICIO 7
            int numero1 = 10;
            int numero2 = 25;
            int resultado7 = numero1 * numero2;
            Console.WriteLine("Ej 7: {0}", resultado7);


            //EJERCICIO 8
            int primerNumero;
            int segundoNumero;
            int producto;


            System.Console.WriteLine("Introduce el primer numero: ");
            primerNumero = System.Convert.ToInt32(
                System.Console.ReadLine());
            System.Console.WriteLine("Introduce el segundo numero: ");
            segundoNumero = System.Convert.ToInt32(
                System.Console.ReadLine());
            producto = primerNumero * segundoNumero;
            System.Console.WriteLine("Ej 8: {0}", producto);


            //EJERCICIO 9
            int numero3;

            Console.WriteLine("Introduce un numero: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero3 % 2 == 0)
                Console.WriteLine("Ej 9: El numero {0} es par", numero3);
            else
                Console.WriteLine("Ej 9: El numero {0} es impar", numero3);


            //EJERCICIO 10
            int numero4;
            int numero5;

            Console.WriteLine("Introduce un numero: ");
            numero4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un numero: ");
            numero5 = Convert.ToInt32(Console.ReadLine());

            if (numero4 > numero5)
                Console.WriteLine("Ej 10: El {0} es mayor que el {1}", numero4, numero5);
            else
                Console.WriteLine("Ej 10: El {1} es mayor que {0}", numero4, numero5);


            //EJERCICIO 11
            int numero6;
            int numero7;
            
            Console.WriteLine("Ingrese un numero: ");
            numero6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            numero7 = Convert.ToInt32(Console.ReadLine());

            float division = numero6 / numero7;

            if (numero7 != 0)
                Console.WriteLine("Ej 11: {0}/{1}={2}", numero6, numero7, division);
            else
                Console.WriteLine("Ej 11: Error! No se puede dividir por {0}", numero7);



            //EJERCICIO 12
            int numero8;

            Console.WriteLine("Ej 12: Ingrese un numero del 1 al 5: ");
            numero8 = Convert.ToInt32(Console.ReadLine());

            switch(numero8)
            {
                case 1: Console.WriteLine("uno");
                        break;
                case 2: Console.WriteLine("dos");
                        break;
                case 3: Console.WriteLine("tres");
                        break;
                case 4: Console.WriteLine("cuatro");
                        break;
                case 5: Console.WriteLine("cinco");
                        break;

            }



            //EJERCICIO 13
            Console.WriteLine("Ej 13");
            int n = 1;

            while (n <= 10)
            {
                Console.WriteLine(n);
                n += 1;
            }


            //EJERCICIO 14
            Console.WriteLine("Ej 14");
            int n1 = 1;

            do
            {
                Console.WriteLine(n1);
                n1 += 1;
            }
            while (n1 <= 10);

            //EJERCICIO 15
            Console.WriteLine("Ej 15");
            int contador;

            for (contador = 10; contador <= 20; contador++)
                Console.Write("{0} ", contador);


            Console.ReadLine();

        }
    }
}
