namespace ConsoleEntities;

public class Person : PersonInterface
{
    public readonly string Name;
    public readonly string Role;

    public Person? batko;
    public Person? mati;
    
    public List<Person>? childrens = new List<Person>();
    

    public Person(string Role, string Name)
    {
        this.Role = Role;
        this.Name = Name;
    }
    
    
    public string getName()
    {
        return Name;
    }
}