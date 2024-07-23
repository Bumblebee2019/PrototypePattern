using System.Xml.Linq;

public interface ISoldier
{
    ISoldier clone();
    String getName();
    void setName(String name);
    String getDescription();
    void setDescription(String description);
}
public class RegularSoldier: ISoldier
{
    private String name;
    private String description;
    public RegularSoldier() {}
    public ISoldier clone()
    {
        return new RegularSoldier();
    }
    public String getName()
    {
        return name;
    }
    public void setName(String name)
    {
        this.name = name;
    }
    public String getDescription()
    {
        return description;
    }
    public void setDescription(String description)
    {
        this.description = description;
    }
}

public class MedicSoldier : ISoldier
{
    private String name;
    private String description;
    public MedicSoldier() {}
    public ISoldier clone()
    {
        return new RegularSoldier();
    }
    public String getName()
    {
        return name;
    }
    public void setName(String name)
    {
        this.name = name;
    }
    public String getDescription()
    {
        return description;
    }
    public void setDescription(String description)
    {
        this.description = description;
    }
}
public class CloneFactory
{
    public static void Main()
    {
        ISoldier regularSoldierPrototype = new RegularSoldier();
        ISoldier medicSoldierPrototype = new MedicSoldier();

        ISoldier clonedRegularSoldier1 = regularSoldierPrototype.clone();
        ISoldier clonedRegularSoldier2 = regularSoldierPrototype.clone();
        ISoldier clonedMedicSoldier1 = medicSoldierPrototype.clone();

        clonedRegularSoldier1.setName("RegularClone #1");
        clonedMedicSoldier1.setName("MedicClone #1");

        clonedRegularSoldier2.setName("RegularClone #2");
        clonedRegularSoldier2.setDescription("fights enemies");

        clonedRegularSoldier1.setDescription("fights enemies");
        clonedMedicSoldier1.setDescription("fights & can give first aid");

        Console.WriteLine(clonedRegularSoldier1.getName() + " " + clonedRegularSoldier1.getDescription() + '\n');
        Console.WriteLine(clonedRegularSoldier2.getName() + " " + clonedRegularSoldier2.getDescription() + '\n');
        Console.WriteLine(clonedMedicSoldier1.getName() + " " + clonedMedicSoldier1.getDescription());
    }
}