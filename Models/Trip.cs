using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet_webapi_ef.Models;
//Dto => โครงสร้างข้อมูลที่จะใช้ตอนรับเข้ากับส่งออกไปจาก webapi
[Table("trip")]
public partial class Trip
{
    [Key]
    [Column("idx")]
    public int Idx { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("country")]
    public string Country { get; set; } = null!;

    [Column("destinationid")]
    public int Destinationid { get; set; }

    [Column("coverimage")]
    public string Coverimage { get; set; } = null!;

    [Column("detail")]
    public string Detail { get; set; } = null!;

    [Column("price")]
    public int Price { get; set; }

    [Column("duration")]
    public int Duration { get; set; }

    [InverseProperty("Trip")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [ForeignKey("Destinationid")]
    [InverseProperty("Trips")]
    public virtual Destination Destination { get; set; } = null!;
}
