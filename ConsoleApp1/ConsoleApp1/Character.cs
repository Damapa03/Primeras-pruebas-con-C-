using ConsoleApp1;

public class Character
{
    public ITem Item;
    public string Name;
    public int MaxHitPoints;
    public int BaseDamage;
    public int BaseArmor;
    private List<ITem> _inventory;

    public Character(ITem item, string name, int maxHitPoints, int baseDamage, int baseArmor)
    {
        Item = item;
        Name = name;
        MaxHitPoints = maxHitPoints;
        BaseDamage = baseDamage;
        BaseArmor = baseArmor;
    }

    public int Attack()
    {
        return 1;
    }
    public int Defense()
    {
        return 1;
    }

    public void Heal(int x)
    {
        
    }

    public void AddItem(ITem item)
    {
        _inventory.Add(item);
    }

    public void RemoveItem(ITem item)
    {
        _inventory.Remove(item);
    }

    public void ReceiveDamage(int damage)
    {
        
    }
}
