namespace calc_something;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World asdd dsads ad sa!");

        string name = Console.ReadLine();
        
        Console.WriteLine($"Hello, {name}!");
        
        Console.WriteLine("How old are you?");
        int age = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"You are {age} years old.");
    }
}
