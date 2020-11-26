using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PROGRAMAS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Resuelva los siguientes algoritmos:
               1. Escriba un programa que pida al usuario que escriba su nombre, y lo salude llamándolo por su nombre.
               2. Escriba un programa que reciba como entrada el radio de un círculo y entregue como salida su perímetro y su área.
               3. Escriba un programa que calcule el promedio de 4 notas ingresadas por el usuario.
               4. Escriba un programa que convierta de centímetros a pulgadas. Una pulgada es igual a 2.54 centímetros.
               5. Escriba un programa que pida al usuario un entero de tres dígitos, y entregue el número con los dígitos en orden inverso.
               6. Escriba un programa que reciba como entrada las longitudes de los dos catetos a y b de un triángulo rectángulo, y que entregue como salida el largo de la hipotenusa c del triangulo, dado por el teorema de Pitágoras: c^2=a^2+b^2.
               7. Escriba un programa que pregunte al usuario la hora actual t del reloj y un número entero de horas h, que indique qué hora marcará el reloj dentro de h horas.
               8. Escriba un programa que entregue la parte decimal de un número real ingresado por el usuario.
             */
            Console.WriteLine("1.Escriba un programa que pida al usuario que escriba " +
                              "\n su nombre, y lo salude llamándolo por su nombre."+
               "\n                                                                                                                     "+
               "\n 2.Escriba un programa que reciba como entrada el radio de un " +
               "\n círculo y entregue como salida su perímetro y su área."+
               "\n                                                                                                                     " +
               "\n 3.Escriba un programa que calcule el " +
               "\n promedio de 4 notas ingresadas por el usuario." +
               "\n                                                                                                                     " +
               "\n 4.Escriba un programa que convierta de centímetros a pulgadas." +
               "\n Una pulgada es igual a 2.54 centímetros." +
               "\n                                                                                                                     " +
               "\n 5.Escriba un programa que pida al usuario un entero de tres " +
               "\n dígitos, y entregue el número con los dígitos en orden inverso." +
               "\n                                                                                                                     " +
               "\n 6.Escriba un programa que reciba como entrada las longitudes " +
               "\n de los dos catetos a y b de un triángulo rectángulo, y que " +
               "\n entregue como salida el largo de la hipotenusa c del triangulo, " +
               "\n dado por el teorema de Pitágoras: c ^ 2 = a ^ 2 + b ^ 2." +
               "\n                                                                                                                     " +
               "\n 7.Escriba un programa que pregunte al usuario la hora " +
               "\n actual t del reloj y un número entero de horas h, que " +
               "\n indique qué hora marcará el reloj dentro de h horas." +
               "\n                                                                                                                     " +
               "\n 8.Escriba un programa que entregue la parte decimal " +
               "\n de un número real ingresado por el usuario."+
               "\n                                                                                                                     ");
         //Variables
         int Menu;
            Console.WriteLine("Digite el indice programa que desea utilizar" +
                "\n");
            Menu = Convert.ToInt32(Console.ReadLine());

            switch (Menu)
            { 
                case 1:

                    Console.WriteLine("1.Escriba un programa que pida al usuario que escriba su " +
                                      "\n nombre, y lo salude llamándolo por su nombre.");
                    //Variables.
                    string Nombre;
                    Console.WriteLine("Digite su nombre");
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Hola " + Nombre);
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("2. Escriba un programa que reciba como entrada el radio " +
                                      "\n de un círculo y entregue como salida su perímetro y su área.");
                    //Variables.
                    double Radio;
                    double pi = 3.14;

                    Console.WriteLine("\n" +
                        "Digite el valor del radio de un circulo");
                    Radio = Convert.ToDouble(Console.ReadLine());
                    double Perimetro = (2*pi*Radio);
                    double Area = (pi)*(Math.Sqrt(Radio));
                    Console.WriteLine(" Perimetro -> "+Perimetro+
                                      "\n Area -> "+Area );
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("\n 3.Escriba un programa que calcule el " +
                                      "\n promedio de 4 notas ingresadas por el usuario.");
                    //Variables.
                    double Materia1, Materia2, Materia3, Materia4;

                    Console.WriteLine("Digite la calificacion de");
                    Materia1 = Convert.ToDouble(Console.ReadLine());
                    Materia2 = Convert.ToDouble(Console.ReadLine());
                    Materia3 = Convert.ToDouble(Console.ReadLine());
                    Materia4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Matematicas -> " + Materia1);
                    Console.WriteLine("Matematicas -> " + Materia2);
                    Console.WriteLine("Matematicas -> " + Materia3);
                    Console.WriteLine("Matematicas -> " + Materia4);

                    double Total = (Materia1 + Materia2 + Materia3 + Materia4);
                    Console.WriteLine(Total);
                    double Promedio = (Total / 4);
                    Console.WriteLine(Promedio);
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("\n 4.Escriba un programa que convierta de centímetros a pulgadas." +
                                      "\n Una pulgada es igual a 2.54 centímetros.");
                    //Variables.
                    double cm;
                    double Pul = 2.54;
                    Console.WriteLine("\n" +
                        "Digite el numero de centimetros a convertir");
                    cm = Convert.ToDouble(Console.ReadLine());
                    double Pulgadas = (cm * Pul);
                    Console.WriteLine("Pulgadas -> " + Pulgadas);
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("\n 5.Escriba un programa que pida al usuario un entero de tres " +
                                      "\n dígitos, y entregue el número con los dígitos en orden inverso.");
                   
                    //Variables.
                    int N = 0;
                    Console.WriteLine("Digite el numero a convertir");
                    N = Convert.ToInt32(Console.ReadLine());
                    int C = (N / 100);
                    Console.WriteLine(C);
                    int Modulo = (N % 100);
                    Console.WriteLine(Modulo);
                    int D = (Modulo / 10);
                    Console.WriteLine(D);
                    int U = (Modulo % 10);
                    Console.WriteLine(U);
                    int Respuesta = (U * 100 + D * 10 + C);
                    Console.WriteLine("El numero es: " + Respuesta);
                    Console.ReadKey();
                    break;

                case 6:
                    Console.WriteLine("\n 6.Escriba un programa que reciba como entrada las longitudes " +
                                      "\n de los dos catetos a y b de un triángulo rectángulo, y que " +
                                      "\n entregue como salida el largo de la hipotenusa c del triangulo, " +
                                      "\n dado por el teorema de Pitágoras: c ^ 2 = a ^ 2 + b ^ 2." );

                    //variables
                    Double A = 0;
                    Double B = 0;
                    Console.WriteLine("Inserte el valor del cateto A");
                    A = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserte el valor del cateto B");
                    B = Convert.ToDouble(Console.ReadLine());
                    Double HIP = Math.Pow(A, 2) + Math.Pow(B, 2);
                    Double H = Math.Sqrt(HIP);
                    Console.WriteLine("La Hipotenusa es: {0}", H);
                    Console.ReadKey();
                    break;

                case 7:
                    Console.WriteLine("\n 7.Escriba un programa que pregunte al usuario la hora " +
                                      "\n actual t del reloj y un número entero de horas h, que " +
                                      "\n indique qué hora marcará el reloj dentro de h horas." );
                    //Funcion del programa
                    Console.WriteLine("Escriba un programa que pregunte al usuario la hora actual t del reloj y un número entero de horas h, que indique qué hora marcará el reloj dentro de h horas.");
                    //Variables
                    string Usuario = "";
                    int Horas = 0;
                    int Minutos = 0;
                    int Horas_en_minutos = (Horas * 60);
                    Console.WriteLine("Digita tu nombre");
                    Usuario = Console.ReadLine();
                    Console.WriteLine("Hola " + Usuario + " digita los siguientes datos");
                    Console.WriteLine("Primero digita las horas");
                    Horas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ahora digita los minutos");
                    Minutos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La hora actual es " + Horas + ":" + Minutos);
                    Console.WriteLine("Ingrese el numero de horas a sumar");
                    int Horas_sumadas = 0;
                    Horas_sumadas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La hora futura sera " + (Horas + Horas_sumadas) + ":" + Minutos);
                    Console.ReadKey();
                    break;

                case 8:

                    //Escriba un programa que entregue la parte decimal de un número real ingresado por el usuario.
                    Console.WriteLine("Escriba un programa que entregue la parte decimal de un número real ingresado por el usuario.");
                    //variables
                    int Numero = 0;
                    Console.WriteLine("Digite un numero");
                    Numero = Convert.ToInt32(Console.ReadLine());
                    int Centena = (Numero % 100);
                    int Decimal = (Centena / 10);
                    Console.WriteLine("El numero decimal es: " + Decimal);
                    Console.ReadKey();

                    break;

            }
        }
    }
}
