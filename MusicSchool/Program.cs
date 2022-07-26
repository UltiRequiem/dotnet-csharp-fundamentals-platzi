class School
{
    public string name;
    public string direction;
    public int fundationYear;
    public string director;

    public School(string schoolName, string schoolDirection, int schoolFundationYear, string schoolDirector)
    {
        name = schoolName;
        direction = schoolDirection;
        fundationYear = schoolFundationYear;
        director = schoolDirector;

    }

    public void ring()
    {
        Console.Beep(987, 1000);
        Console.Beep(1174, 500);
        Console.Beep(880, 1500);

        Console.Beep(783, 250);
        Console.Beep(880, 250);
        Console.Beep(987, 1000);

        Console.Beep(1174, 500);
        Console.Beep(880, 1500);

        Console.Beep(987, 1000);
        Console.Beep(1174, 500);
        Console.Beep(1760, 1000);
        Console.Beep(1567, 500);
        Console.Beep(1174, 1000);

        Console.Beep(1046, 250);
        Console.Beep(987, 250);
        Console.Beep(880, 1000);
    }

}

class Program
{
    static void Main(string[] args)
    {
        var school = new School("Platzi", "Lima", 2000, "Freddy");
        school.ring();
    }
}
