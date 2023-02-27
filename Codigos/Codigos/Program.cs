/// <summary>
/// Los siguientes ejercicios estan cada uno por separado
/// trabajando con funciones y en cada encabezado
/// menciona sobre su objetivo.
/// Ejercicio:1
/// Objetivo: Multiplicar dos números tecleados por usuario.
/// </summary>

namespace multiplicar
{
    class MainClass
    {
        public static float numero1;
        public static float numero2;  

        public static void Main(string[] args)  
        {
            string nombre;
            int opcion;
            Console.Write("Por favor ingresa tu nombre: ");
            nombre = (Console.ReadLine());
            do
            {
                Console.Write("Marca 1 para ingresar al programa");
                Console.WriteLine(" o 0 (cero) para salir: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        float numero1, numero2, total = 0;
                        Console.Write("Ingrese un numero: ");
                        numero1 = float.Parse(Console.ReadLine());
                        Console.Write("Ingresa otro numero: ");
                        numero2 = float.Parse(Console.ReadLine());

                        if (numero1 == 0 || numero2 == 0)
                        {
                            Console.WriteLine(nombre + ", no se pueden realizar operaciones de multiplicación con cero");
                        }
                        float resultadoSuma = Multiplicacion(numero1, numero2);
                        Console.WriteLine(nombre + ", El resultado de los números multiplicados es: " + resultadoSuma);
                        Console.WriteLine("\n");
                        break;

                    case 0:
                        Console.Write(nombre + ", gracias por usar nuestro programa");
                        Console.WriteLine("\n");
                        break;

                    default:
                        Console.Write("La opción ingresada no aparece en el menú. Vuelve a intentarlo.");
                        Console.WriteLine("\n");
                        break;
                }
            } while (opcion != 0);
        }
        public static float Multiplicacion(float dato1, float dato2)
        {
            return dato1 * dato2;
        }
    }
}


/// <summary>
/// Ejercicio: 2
/// Objetivo:El usuario tecleará dos números (x e y), y el programa 
/// deberá calcular cuál es elresultado de su división y 
/// el resto de esa división. Deberás pedir los datos, e incluir
/// un comentario con tu nombre y la fecha en que has realizado 
/// el programa.
/// NOMBRE ESTUDIANTE: Elkin Riaño Díaz
/// FECHA DE ENTREGA: 16 de febrero de 2023
/// </summary>

/*namespace division
{
    class MainClass
    {
        public static float numero1;
        public static float numero2;
        public static void Main(string[] Args)
        {
            string nombre;
            Console.WriteLine("Aprende a dividir con nuestro programa");
            Console.Write("Coloca tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Digita por favor dos número enteros");
            Console.Write("Ingresa por favor un número: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("Digita por favor otro número: ");
            numero2 = float.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                float resultado = Multiplicar(numero1, numero2);
                Console.WriteLine("El número 2 esta: " + resultado + " veces en el número 1");
                Console.WriteLine(nombre + ", la división completa es: " + resultado);
                float resultado1 = Sobrante(numero1, numero2);
                Console.WriteLine("y tiene un sobrante de: " + resultado1);
                Console.WriteLine("\n");
            }
            if (numero1 == numero2)
            {
                Console.Write(nombre + ", recuerda que cualquier número dividido por si mismo da 1");
                Console.WriteLine("\n");
            }
            else if (numero1 < numero2)
            {
                float resultado1 = Multiplicar(numero1, numero2);
                Console.WriteLine(nombre + ", el resultado de la división es: " + resultado1);
                Console.WriteLine("\n");
            }
        }
        public static float Multiplicar(float dato1, float dato2)
        {
            return dato1 / dato2;
        }
        public static float Sobrante(float dato1, float dato2)
        {
            return dato1 % dato2;
        }
    }
}*/


/// <summary>
/// Ejercicio:3
/// Objetivo: Sumar tres números tecleados por usuario.
/// </summary>
/*namespace sumas
{
    class MainClass
    {
        public static float numero1;
        public static float numero2;
        public static float numero3;    
        public static void Main(string[] Args)
       {
            saludos();
            Console.Write("Ingresa el primer número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el tercer número: ");
            numero3 = int.Parse(Console.ReadLine());
            float total = Sumando(numero1, numero2, numero3);
            Console.WriteLine("El total de la suma es: " + total);
       }
       public static void saludos()
       {
          Console.WriteLine("Programa para sumar");
          Console.WriteLine("Digita por favor tres número enteros");
       }
       public static float Sumando(float dato1, float dato2, float dato3)
       {
            return dato1 + dato2 + dato3;
       }
    }   
}*/

/// <summary>
/// Ejercicio: 4
/// Objetivo: Pedir al usuario un número y mostrar su tabla de multiplicar. 
/// Por ejemplo, si el número es el 3, debería escribirse algo como:
/// 3 x 0 = 0
/// 3 x 1 = 3
/// 3 x 2 = 6
/// …
/// 3 x 10 = 30
/// </summary>

/*namespace tablas
{
    class MainClass
    {
        public static float numero1;
        public static void Main(string[] Args)
        {
            Console.WriteLine("VAMOS A CONOCER LA TABLAS DE MULTIPLICAR");
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingresa cualquier número positivo entero: ");
            numero1 = int.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " * " + numero1 + " = " + i * numero1);
            }
            Console.WriteLine("\n");
            float raiz = Raiz(numero1);
            Console.WriteLine("La raiz cuadrada en la presente tabla de multiplicar es: " + raiz);
        }
        public static float Raiz(float dato1)
        {
            return dato1 * dato1;
        }
    }  
}*/

/// <summary>
/// Ejercicio: 5
/// Objetivo: Crea un programa que convierta de grados Celsius (centígrados)
/// a Kelvin y a Fahrenheit: pedirá al usuario la cantidad de grados 
/// centígrados y usará las siguiente tablas de conversión: 
/// kelvin = celsius + 273 ; fahrenheit = celsius x 18 / 10 + 32
/// </summary>


/*namespace tablas
{
    class MainClass
    {
        public static float numero1;
        public static void Main (string[] Args)
        {
            int eleccion;
            do
            {
                
                Console.WriteLine(" _______________________________________________________");
                Console.WriteLine("|     Conversor Temperatura CELSIUS a otras medidas     |");
                Console.WriteLine("|      Por favor lea atentamente el siguiente menú:     |");
                Console.WriteLine("|                                                       |");
                Console.WriteLine("|1 Conversión a KELVIN       | 2 Conversión a FAHRENHEIT|");
                Console.WriteLine("|3 Salir de programa         |                          |");
                Console.WriteLine(" -------------------------------------------------------");
                Console.Write("Ingresa la opcion que deseas: ");
                eleccion = int.Parse(Console.ReadLine());
                switch (eleccion)
                {
                    case 1:
                        Console.Write("Ingresa la medida de CELSIUS para convertir a KELVIN: ");
                        numero1 = int.Parse(Console.ReadLine());
                        float conversion1 = Kelvin(numero1);
                        Console.Write("La conversión de " + numero1 + " celsius, equivale a " + conversion1 + " Kelvin");
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        Console.Write("Ingresa la medida de CELSIUS para convertir a FAHRENHEIT: ");
                        numero1 = int.Parse(Console.ReadLine());
                        float conversion2 = Fahrenheit(numero1);
                        Console.Write("La conversión de " + numero1 + " celsius, equivale a " + conversion2 + " Fahrenheit");
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        Console.Write("Gracias por pensar en nuestros servicios");
                        Console.WriteLine("\n");
                        break;

                    default:
                        Console.Write("La opción ingresada no aparece en el menú. Vuelve a intentarlo.");
                        Console.WriteLine("\n");
                        break;
                }
            } while (eleccion != 3);
        }
        public static float Kelvin (float dato1)
        {
            return dato1 + 273;
        }
        public static float Fahrenheit(float dato1)
        {
            return (dato1 / 5) * 9 + 32;
        }
    }
}*/


/// <summary>
/// Ejercicio: 6
/// Objetivo:Pide al usuario una cantidad de "millas" y muestra 
/// la equivalencia en metros,usando: 1 milla = 1609.344 metros.
/// </summary>


/*namespace conversor
{
    class MainClass
    {
        public static float eleccion;
        public static float numero1;
        
        public static void Main(string[] Args)
        {
            Console.WriteLine("CONVERSOR DE METROS Y MILLAS");
            Console.WriteLine("||||||||||||||||||||||||||||");
            Console.WriteLine("Marca 1 para convertir de millas a metros");
            Console.WriteLine("Marca 2 para convertir de metros a millas");
            Console.WriteLine("\n");
            Console.Write("Ingrese la opción deseada: ");
            eleccion = float.Parse(Console.ReadLine());

            if (eleccion == 1)
            {
                Console.Write("Ingrese el valor en millas: ");
                numero1 = float.Parse(Console.ReadLine());
                float conversionMetro = Conversion1(numero1);
                Console.WriteLine("Las millas ingresadas equivalen a " + conversionMetro + " metros");
            }
            else if (eleccion == 2)
            {
                Console.Write("Ingrese el valor en metros: ");
                numero1 = float.Parse(Console.ReadLine());
                float conversionMilla = Conversion2(numero1);
                Console.WriteLine("Las metros ingresados equivalen a " + conversionMilla + " millas");
            }  
        }
        public static float Conversion1 (float dato1)
        {
            return dato1 * 1609;
        }
        public static float Conversion2 (float dato1)
        {
           return dato1 * 00062137;
        }
    }
}*/


/// <summary>
/// Ejercicio: 7
/// Objetivo:Crear un programa que pida al usuario un número entero. 
/// Si es múltiplo de 10, se lo avisará al usuario y pedirá un segundo
/// número, para decir a continuación si este segundo número también
/// es múltiplo de 10.
/// </summary>

/*namespace conversor
{
    class MainClass
    {
        public static float numero1;
        public static float numero2;
        public static void Main(string[] Args)
        {
            proceso();
        }
        public static void proceso()
        {
            Console.WriteLine("Conozcamos los múltiplos del número 10");
            Console.WriteLine("Para ello debes ingresar un numero entero");
            Console.WriteLine("\n");
            Console.WriteLine("Recuerda que los números enteros pueden ser");
            Console.WriteLine("negativos o positivos y no cuentan con decimales");
            Console.Write("Por favor ingrese un número entero: ");
            numero1 = float.Parse(Console.ReadLine());
            Multiplo(numero1);                     
    }
        public static void Multiplo(float dato1)
        {
            if (dato1 % 10 == 0)
            {
                Console.WriteLine("El número ingresado SI es multiplo de 10");
                Console.WriteLine("\n");
                Console.Write("Por favor ingrese otro número entero: ");
                numero1 = float.Parse(Console.ReadLine());
                Multiplo(numero1);
                Console.WriteLine("\n");
            }
            else
            {
                Console.Write("EL número que ingresaste NO es múltiplo de 10");
                Console.WriteLine("\n");
            }
        }
    }
} */


/// <summary>
/// Ejercicio: 8
/// Objetivo:Crear un programa que multiplique dos números enteros de la 
/// siguiente forma: pedirá al usuario un primer número entero.Si el número 
/// que se que teclee es 0, escribirá en pantalla "El producto de 0 por 
/// cualquier número es cero". Si se ha tecleado un número distinto de cero,
/// se pedirá al usuario un segundo número y se mostrará el producto de ambos.
/// </summary>


/*namespace conversor
{
    class MainClass
    {
        public static float numero1;
        public static float numero2;
        public static void Main(string[] Args)
        {
            Console.WriteLine("Multipliquemos ahora");
            Console.WriteLine("--------------------");
            Console.Write("Por favor ingrese el número que desees: ");
            numero1 = float.Parse(Console.ReadLine());
            if (numero1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es cero. No es posible multiplicación");
                Console.WriteLine("\n");
            }
            else if (numero1 != 0)
            {
                Console.Write("Por favor ingrese otro número: ");
                numero2 = float.Parse(Console.ReadLine());               
                Console.WriteLine("\n");
                float multiplicacion = Programa(numero1, numero2);
                Console.WriteLine("La multiplicación tiene de resultado: " + multiplicacion);      
            } 
        }
        public static float Programa(float dato1, float dato2)
        {
            return dato1 * dato2;
        }
    }         
}*/
