using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet_webapi_ef.Models;

[Table("booking")]
public partial class Booking
{
    [Key]
    [Column("idx")]
    public int Idx { get; set; }

    [Column("customerid")]
    public int Customerid { get; set; }

    [Column("bookdatetime")]
    public string Bookdatetime { get; set; } = null!;

    [Column("tripid")]
    public int Tripid { get; set; }

    [Column("meetingid")]
    public int Meetingid { get; set; }

    [ForeignKey("Customerid")]
    [InverseProperty("Bookings")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("Meetingid")]
    [InverseProperty("Bookings")]
    public virtual Meeting Meeting { get; set; } = null!;

    [ForeignKey("Tripid")]
    [InverseProperty("Bookings")]
    public virtual Trip Trip { get; set; } = null!;
}
