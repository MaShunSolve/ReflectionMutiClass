using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseSettingGetTarget
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
        public Demo query_input { get; set; }
    }
    public class Demo
    { 
        public string d { get; set; }
        public string e { get; set; }
        public string f { get; set; }
    }
}
