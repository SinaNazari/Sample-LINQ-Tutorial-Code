
class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>()
        {
            0, 17, 18,19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
        };

        var names = new List<string>()
        {
            "Sina","Ali","Reza","Mina","Sara","Darya"
        };


        var result = numbers.Where(n => n % 2 == 0).ToList();

        var result2 = names.Where(n => n.Contains("e")).ToList();


        foreach (var item in result)
        {
            Console.WriteLine($"Number is: {item}");
        }

        Console.WriteLine("*******************************");


        foreach (var item in result2)
        {
            Console.WriteLine($"Name is: {item}");
        }
    }
}