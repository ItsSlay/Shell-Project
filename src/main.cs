class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            
            Console.Write("$ ");
            var Test = Console.ReadLine();
            if (Test == "exit") {
                return;
            }else if (Test.StartsWith("echo"))
            {
                Console.WriteLine(Test[5..]);
            }
            else
            {
            Console.WriteLine($"{Test}: command not found");

            }
            
        }
        
    }
}
