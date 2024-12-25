namespace FakeUnit.Models;
public class Category
{
    public int Id { get; set; } 
    public string Name { get; set; }

    public Category() {}

    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString() => $"Id : {Id}\nName : {Name}";
}
