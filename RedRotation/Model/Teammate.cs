using System.ComponentModel.DataAnnotations;

namespace RedRotation.Model
{
  public class Teammate
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }
  }
}
