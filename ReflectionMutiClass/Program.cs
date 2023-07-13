using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Type type = typeof(ClassA);
        var properties  = type.GetProperties();
        foreach (var item in properties)
        { 
            Console.WriteLine(item.Name);//屬性名稱
            Console.WriteLine(item.PropertyType);//屬性型別
            Console.WriteLine(item.Module);//dll名稱
            Console.WriteLine(item.DeclaringType);//宣告這個變數的型別
            if (item.PropertyType.ToString() != "System.String")
            {
                Console.WriteLine("-->");
                Type subType = Type.GetType(item.PropertyType.ToString());
                foreach (var subItem in subType.GetProperties())
                {
                    
                    Console.WriteLine(subItem.Name);//屬性名稱
                    Console.WriteLine(subItem.PropertyType);//屬性型別
                    Console.WriteLine(subItem.Module);//dll名稱
                    Console.WriteLine(subItem.DeclaringType);//宣告這個變數的型別
                }
            }
            Console.WriteLine("---------------------");
        }
    }
}
/// <summary>
/// 最外層
/// </summary>
public class ClassA
{ 
    /// <summary>
    /// 頁籤
    /// </summary>
    public string page { get; set; }
    /// <summary>
    /// 子類
    /// </summary>
    public SubClassA sub { get; set; }
}
/// <summary>
/// 子類
/// </summary>
public class SubClassA
{ 
    /// <summary>
    /// 屬性a
    /// </summary>
    public string pro_a { get; set; }
    /// <summary>
    /// 屬性b
    /// </summary>
    public string pro_b { get; set; }
    /// <summary>
    /// 屬性c
    /// </summary>
    public string pro_c { get; set; }
}