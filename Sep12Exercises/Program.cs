using System.Reflection;
namespace Sep12Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\saivignesh\source\repos\Sep12Exercises\Sep12\bin\Debug\Sep12.dll";
            Assembly asm = Assembly.LoadFrom(path);
            Type[] types = asm.GetTypes();
            Type t = null;
            foreach (var item in types)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.FullName);
                MemberInfo[] min = item.GetMembers();
                foreach (var item1 in min)
                {
                    Console.WriteLine(item1.Name);
                }
                MethodInfo[] max = item.GetMethods();
                foreach (var item2 in max)
                {
                    Console.WriteLine(item2.Name);

                    ParameterInfo[] pinfo = item2.GetParameters();
                    foreach (var p in pinfo)
                    {
                        Console.WriteLine("Parameter Name: " + p.Name);
                        Console.WriteLine("Parameter Position: " + p.Position);
                        Console.WriteLine("Parameter Type: " + p.ParameterType);
                    }
                }
                t = asm.GetType(item.FullName);
                object obj = Activator.CreateInstance(t);



                double cube = (double)item.InvokeMember("Cube1", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 400.0d });
                Console.WriteLine("Cube number is" + " " + cube);
                double sqrt = (double)item.InvokeMember("squareroot", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 200.0d });
                Console.WriteLine("Square root number is" + " " + sqrt);
                break;
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Custom attributes");
            Program.WritedataForEachCode(typeof(song));
            Console.Read();
            Console.ReadLine();


        }
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is Stereodisc)
                {
                    Stereodisc a = (Stereodisc)attr;
                    System.Console.WriteLine($"{a.songname} {a.slanguage} {a.slyrics}");
                }
            }
            Console.WriteLine("---------------------------------");
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is Stereodisc)
                    {
                        Stereodisc a = (Stereodisc)attrItem;
                        System.Console.WriteLine($"{a.songname} {a.slanguage} {a.slyrics}");
                    }
                }

            }
        }
    }
}