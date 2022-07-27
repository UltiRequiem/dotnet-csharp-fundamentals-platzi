namespace MusicSchool;
using static Console;

internal class School
{
    private string _name;
    private string _direction;

    public School(string schoolName, string schoolDirection)
    {
        _name = schoolName;
        _direction = schoolDirection;
    }

    public void ring()
    {
        Beep(987, 1000);
        Beep(1174, 500);
        Beep(880, 1500);

        Beep(783, 250);
        Beep(880, 250);
        Beep(987, 1000);

        Beep(1174, 500);
        Beep(880, 1500);

        Beep(987, 1000);
        Beep(1174, 500);
        Beep(1760, 1000);
        Beep(1567, 500);
        Beep(1174, 1000);

        Beep(1046, 250);
        Beep(987, 250);
        Beep(880, 1000);
    }

}

internal static class Program
{
    private static void Main(string[] args)
    {
        var school = new School("Platzi","Lima");
        school.ring();
    }
}
