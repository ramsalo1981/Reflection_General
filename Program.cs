using System.Reflection;

namespace CAReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t1 = DateTime.Now.GetType();// at runtime
            Console.WriteLine(t1);

            Type t2 = typeof(DateTime); // at compile time
            Console.WriteLine(t2);

            Console.WriteLine($"Fullname: {t1.FullName}"); //namespace.typename
            Console.WriteLine($"Namespace: {t1.Namespace}");//namespace
            Console.WriteLine($"Name: {t1.Name}");
            Console.WriteLine($"BaseType: {t1.BaseType}");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine($"IsPublic: {t1.IsPublic}");
            Console.WriteLine($"Assembly: {t1.Assembly}");
            Console.WriteLine("------------------------------\n");

            Type t3 = typeof(int[,]);
            Console.WriteLine($"t3 type: {t3.Name}");
            Console.WriteLine("------------------------------\n");

            var nestedTypes = typeof(Employee).GetNestedTypes();
            for (int i = 0; i < nestedTypes.Length; i++)
            {
                Console.WriteLine(nestedTypes[i]);
            }
            Console.WriteLine("------------------------------\n");

            var t4 = typeof(int);
            var interFace = t4.GetInterfaces();
            for (int i = 0; i < interFace.Length; i++)
            {
                Console.WriteLine(interFace[i]);
            }
            Console.WriteLine("------------------------------\n");

            int j = (int)Activator.CreateInstance(typeof(int));
            j = 3;

            DateTime dt = (DateTime)Activator.CreateInstance(typeof(DateTime), 2023, 02, 02);
            Console.WriteLine(dt);
            Console.WriteLine("------------------------------\n");


            Console.ReadKey();
        }
    }

    public class Employee
    {
        public class FullTimeEmployee
        {

        }
    }
}