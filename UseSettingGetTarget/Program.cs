using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string[] strArr = new string[] { };
        if (a == "1")
            strArr = new string[] { "UseSettingGetTarget.TestService", "MehtodA", "query_input", "UseSettingGetTarget.Demo" };
        else
            strArr = new string[] { "UseSettingGetTarget.TestServiceB", "MethodB", "query_input", "UseSettingGetTarget.SubDemoC" };
        Type serviceType = Type.GetType(strArr[0]);
        object obj = Activator.CreateInstance(serviceType);
        MethodInfo methodInfo = serviceType.GetMethod(strArr[1]);
        if (methodInfo is not null)
        {

            ParameterInfo parameters = methodInfo.GetParameters().FirstOrDefault();
            Type paramType = Type.GetType(parameters.ParameterType.FullName);
            PropertyInfo queryObj = paramType.GetProperty(strArr[2]);//query input
            if (queryObj is not null)
            {
                Console.WriteLine(queryObj.DeclaringType);
                Type qc = queryObj.PropertyType;
                if (queryObj.PropertyType.ToString() == strArr[3])
                {
                    object qi = Activator.CreateInstance(qc);
                    ProcessProperties(qc);
                }
                else
                {
                    Recursive(qc, strArr[3]);
                }
            }
        }
    }
    private static void ProcessProperties(Type targetType)
    {
        foreach (var item in targetType.GetProperties())
        {
            Console.WriteLine(item.Name);
            Console.WriteLine("----------");
        }
    }

    private static void Recursive(Type qc, string target)
    {
        foreach (var item in qc.GetProperties())
        {
            if (item.PropertyType.ToString() == target)
            {
                Type type = item.PropertyType;
                ProcessProperties(type);
            }
            else 
            {
                if (item.PropertyType.IsClass)
                {
                    Console.WriteLine($"New Recursive : {item.PropertyType}");
                    Recursive(item.PropertyType, target);
                }
            }
        }
    }
}