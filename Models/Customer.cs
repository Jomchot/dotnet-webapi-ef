using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet_webapi_ef.Models;

[Table("customer")]
public partial class Customer
{
    [Key]
    [Column("idx")]
    public int Idx { get; set; }

    [Column("fullname")]
    public string Fullname { get; set; } = null!;

    [Column("phone")]
    public string Phone { get; set; } = null!;

    [Column("email")]
    public string Email { get; set; } = null!;

    [Column("image")]
    public string Image { get; set; } = null!;

    [Column("password")]
    public string Password { get; set; } = null!;

    [InverseProperty("Customer")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
