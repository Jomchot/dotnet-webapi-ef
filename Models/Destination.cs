using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet_webapi_ef.Models;

[Table("destination")]
public partial class Destination
{
    [Key]
    [Column("idx")]
    public int Idx { get; set; }

    [Column("zone")]
    public string Zone { get; set; } = null!;

    [InverseProperty("Destination")]
    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
