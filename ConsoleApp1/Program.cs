class Progaram 
{
    static void Main(string[] args)

    {
        Console.WriteLine("Write a number");
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number");
            return;
        }
        Console.WriteLine("Write a number");
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number");
            return;
        }
        Console.WriteLine("Write a & or ^");
        var s = Console.ReadLine();
        if (s.Length>1 || s.Length ==0)
        {
            Console.WriteLine("Error!");
        return;
        }
        switch (s[0])
        {
            case '&':
                var end1 = a & b;
                string end2 = Convert.ToString(end1, 2);
                string end3 = Convert.ToString(end1, 16);

                Console.WriteLine("{0} {1} {2}", end1, end2, end3);
                break;

            case '^':
                var end10 = a ^ b;
                string end20 = Convert.ToString(end10, 2);
                string end30 = Convert.ToString(end10, 16);

                Console.WriteLine("{0} {1} {2}", end10, end20, end30);
                break;

            case '|':
                var end100 = a | b;
                string end200 = Convert.ToString(end100, 2);
                string end300 = Convert.ToString(end100, 16);

                Console.WriteLine("{0} {1} {2}", end100, end200, end300);
                break;

            default:
                Console.WriteLine("Error!");
                break;
        }
    }
}
