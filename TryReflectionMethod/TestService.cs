using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryReflectionMethod
{
    public class TestService
    {
        public void MehtodA(IntpuTest a)
        {
            Console.WriteLine("好扯喔");
        }
    }
    public class IntpuTest
    { 
        public string pro_a { get; set; }
        public string pro_b { get; set; }
        public string pro_c { get; set; }
    }
}
