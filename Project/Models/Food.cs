namespace burgerJoint.Models
{
  abstract class Food
  {
    public string Name { get; set; }
    public string Id { get; set; }
    public Food(string name, string id)
    {
      Name = name;
      Id = id;
    }
  }
}