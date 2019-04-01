namespace burgerJoint.Models
{
  class Entree : Food
  {
    public string Size { get; set; }

    public Entree(string name, string id, string size) : base(name, id)
    {
      Size = size;
    }
  }
}