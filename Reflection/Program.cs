using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var asemmblies = Assembly.GetExecutingAssembly();


            Console.WriteLine("All types");
            foreach (var item in asemmblies.GetTypes())
            {
                Console.WriteLine(item.Name + " - " + item.Namespace);
                foreach (var field in item.GetFields())
                {
                    Console.WriteLine("\t" + field.Name);
                }
            }

            Product product = new Product(4)
            {
                SalePrice = 2,
                Name = "Cola 1L",
                Category = "Zeherli Madde"
            };

            var type = product.GetType();

            Console.WriteLine("\nProperties: ");
            foreach (var item in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                Console.WriteLine($"{item.Name} - {item.GetValue(product)}");
            }

            Console.WriteLine("\nFields: ");
            foreach (var item in type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                if (item.Name == "_costPrice")
                {
                    item.SetValue(product, 12);
                }
                Console.WriteLine($"{item.Name} - {item.GetValue(product)}");

            }

            Console.WriteLine("\nMethods: ");
            foreach (var item in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                Console.WriteLine(item.Name);
            }


        }
    }
}
