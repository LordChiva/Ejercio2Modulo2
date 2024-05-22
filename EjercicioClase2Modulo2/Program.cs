using System.Text.Json;

namespace EjercicioClase2Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando LINQ resolver las siguientes consignas:

            //Carga de datos
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true},
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };


            #region Ejercicio1

            // Detectar cual es el numero mas grande e imprimirlo por consola

            var lstNumeros = new List<int>() { 25,10,99,105, 1, 84, 22};

            Console.WriteLine("Ejercicio 1");
            var mayorNum = lstNumeros.Max(max => max);
            Console.WriteLine(mayorNum.ToString());

            #endregion

            #region Ejercicio2

            //Ordenar los nombres alfabeticamente
            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };

            Console.WriteLine("Ejercicio 2");
            var nombresOrdenados = lstNombres.OrderBy(alph => alph).ToList();
            var serializado2 = JsonSerializer.Serialize(nombresOrdenados);
            Console.WriteLine(serializado2);

            #endregion

            #region Ejercicio3
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola

            Console.WriteLine("Ejercicio 3");
            var vips = lstClientes.Select(clientes => clientes).Where(clientes => clientes.Vip.Equals(true)).ToList();
            var serializado3 = JsonSerializer.Serialize(vips);
            Console.WriteLine(serializado3);

            #endregion

            #region Ejercicio4 

            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren
            //los nombres de los clientes e imprimir los nombres
            Console.WriteLine("Ejercicio 4");
            var nombreClientes = lstClientes.Select(clientes => clientes.Nombre).ToList();
            var serializado4 = JsonSerializer.Serialize(nombreClientes);
            Console.WriteLine(serializado4);

            #endregion

            #region Ejercicio5
            //Apartir de la variable "lstClientes" crear una lista que contenga
            //todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"

            Console.WriteLine("Ejercicio 5");
            var lstCliPremium = lstClientes
                .Select(c => new { Apellido = c.Apellido.ToUpper(),
                    Nombre = c.Nombre.ToUpper(),
                    CodCliente = c.CodCliente,
                    Vip = c.Vip
            // Esta parte no me quedo clara de cómo poner una condición
            //      Vip = if (c.Vip) { Vip = "Premium"} else { Vip = "Normal"}
                }).ToList();
            var serializado5 = JsonSerializer.Serialize(lstCliPremium);
            Console.WriteLine(serializado5);

            #endregion
        }
    }
}