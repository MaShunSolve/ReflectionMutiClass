using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseSettingGetTarget
{
    internal class TestServiceB
    {
        public void MethodB(IntpuTestB input)
        {
            Console.WriteLine($"GG:{input.query_input.e.gg}");
            Console.WriteLine($"YY:{input.query_input.e.yy}");
        }
    }
    public class IntpuTestB
    {
        public string pro_a { get; set; }
        public string pro_b { get; set; }
        public string pro_c { get; set; }
        public DemoB query_input { get; set; }
    }
    public class DemoB
    {
        public SubDemoB d { get; set; }
        public SubDemoC e { get; set; }
    }
    public class SubDemoB
    { 
        public string kk { get; set; }
        public string ll { get; set; }
    }
    public class SubDemoC : BaseModel
    {
        public string gg { get; set; }
        public string yy { get; set; }
    }
}
