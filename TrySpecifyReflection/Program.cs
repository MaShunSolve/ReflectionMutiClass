internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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