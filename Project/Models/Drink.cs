namespace burgerJoint.Models
{
  abstract class Drink
  {
    public string Name { get; set; }
    public string Id { get; set; }
    public string Size { get; set; }
    public Drink(string name, string id, string size)
    {
      Name = name;
      Id = id;
      Size = size;
    }
  }
}