namespace ConsoleApp1;

public abstract class Weapon : ITem
{
    public String Name;
    public int Damage;

    protected Weapon(string name)
    {
        Name = name;
    }

    public void Apply(Character character)
    {
        throw new NotImplementedException();
    }
}