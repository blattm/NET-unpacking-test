class Loader
{
    static void Main(string[] args)
    {
        string s = "";

        byte[] assemblyBytes = System.Convert.FromBase64String(s);
            
        System.Reflection.Assembly assembly = System.Reflection.Assembly.Load(assemblyBytes);
        System.Console.WriteLine("Loaded Assembly");
        assembly.EntryPoint.Invoke(null, new object[]{ args });
        System.Console.WriteLine("Assembly was executed");
    }
}












