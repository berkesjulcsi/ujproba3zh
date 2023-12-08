using System;
using System.Collections.Generic;

namespace ujproba3zh.Models;

public partial class Ügyintézések
{
    public int ÜgyintézésId { get; set; }

    public int? ÜgyfélId { get; set; }

    public int? DolgozóId { get; set; }

    public string? Status { get; set; }

    public bool? SzemélyesenE { get; set; }

    public DateTime? Kezdet { get; set; }

    public DateTime? Vég { get; set; }

    public virtual Dolgozók? Dolgozó { get; set; }

    public virtual Ügyfelek? Ügyfél { get; set; }
}
