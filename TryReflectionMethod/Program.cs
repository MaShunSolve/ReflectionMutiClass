using System.Reflection;
using TryReflectionMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Type type = typeof(TestService);
        MethodInfo[] methodInfo = type.GetMethods();
        foreach (MethodInfo item in methodInfo)
        { 
            Console.WriteLine($"Method Name = {item.Name}");
            foreach (var tmp in item.GetParameters())
            { 
                Console.WriteLine($"Param Type = {tmp.ParameterType}");
                Console.WriteLine($"Return Type = {item.ReturnType}");
            }
        }
    }
}