using System;
using System.Collections.Generic;

namespace bier_backend.Models
{
    public partial class Bier
    {
        public long Id { get; set; }
        public string? Naam { get; set; }
        public string? Brouwer { get; set; }
        public string? Type { get; set; }
        public string? Gisting { get; set; }
        public double? Perc { get; set; }
        public byte[] InkoopPrijs { get; set; } = null!;
    }
}
