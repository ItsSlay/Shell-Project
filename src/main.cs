class Program
{
    static void Main()
    {

        while (true)
        {
            
            Console.Write("$ ");
            var Test = Console.ReadLine();
            if (Test == "exit") {
                return;
            }
            else
            {
            Console.WriteLine($"{Test}: command not found");

            }
            
        }
        
    }
}
