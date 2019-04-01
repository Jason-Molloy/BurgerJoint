namespace burgerJoint.Models
{
  class Side : Food
  {
    public string Size { get; set; }
    public Side(string name, string id, string size) : base(name, id)
    {
      Size = size;
    }
  }
}