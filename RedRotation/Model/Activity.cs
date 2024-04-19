using System.ComponentModel.DataAnnotations;

namespace RedRotation.Model
{
  public class Activity
  {
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string LastRotationDate { get; set; }

    public List<Teammate> Members { get; set; }
  }
}
