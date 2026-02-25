using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week3MicroService.Models;

[Table("Customers")]
public partial class Customer
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column("first_name")]
    [StringLength(100)]
    public string FirstName { get; set; } = null!;

    [Required]
    [Column("last_name")]
    [StringLength(100)]
    public string LastName { get; set; } = null!;

    [Required]
    [Column("phone")]
    [StringLength(100)]
    public int Phone { get; set; }

    [Required]
    [Column("email")]
    [StringLength(100)]
    public string Email { get; set; } = null!;
}
