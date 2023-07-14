using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvokeMethod
{
    public class Service
    {
        public static void MethodA()
        {
            Console.WriteLine("好扯");
        }
        public void MethodB()
        {
            Type type = typeof(Service);
            var method = type.GetMethod("MethodA");
            method.Invoke(null, null);
        }
    }
}
