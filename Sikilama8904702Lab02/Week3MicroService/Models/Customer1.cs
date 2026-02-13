using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Week3MicroService.Models;

[Table("Customers")]
public partial class Customer1
{
    [Key]
    public int Id { get; set; }

    [Column("first_name")]
    public string FirstName { get; set; } = null!;

    [Column("last_name")]
    public string LastName { get; set; } = null!;

    [Column("phone")]
    public int Phone { get; set; }

    [Column("email")]
    public string Email { get; set; } = null!;
}
