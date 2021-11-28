class Program
{
    static void Main(string[] args)
    {
        int[] number = { 1, 2, 3, 4, 10, 20, 30, 40, 50, 60 };


        var reulst = (from n in number  //Linq
                      where n > 20
                      select n).ToList();

        var result1 = number.Where(n => n > 20); //lambda

        var result2 = number.Where(GetNumberOver50); //Method

        var result3 = number.Where(delegate (int num) { return num > 20; }); //Anonymous Method

    }

    private static bool GetNumberOver50(int num)
    {
        return num > 20;
    }
}