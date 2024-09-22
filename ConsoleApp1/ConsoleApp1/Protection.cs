namespace ConsoleApp1;

public class Protection: ITem
{
    public String Name;
    public int Armor;

    public Protection(string name)
    {
        Name = name;
    }

    public void Apply(Character character)
    {
        throw new NotImplementedException();
    }
}