using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet_webapi_ef.Models;

[Table("meeting")]
public partial class Meeting
{
    [Key]
    [Column("idx")]
    public int Idx { get; set; }

    [Column("detail")]
    public string Detail { get; set; } = null!;

    [Column("meetingdatetime")]
    public string Meetingdatetime { get; set; } = null!;

    [Column("latitude")]
    public double Latitude { get; set; }

    [Column("longitude")]
    public double Longitude { get; set; }

    [InverseProperty("Meeting")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
