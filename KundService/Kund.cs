namespace KundService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kund")]
    public partial class Kund
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Losenord { get; set; }

        [Required]
        [StringLength(50)]
        public string Fornamn { get; set; }

        [Required]
        [StringLength(50)]
        public string Efternamn { get; set; }

        [Required]
        [StringLength(10)]
        public string PersonNr { get; set; }

        [StringLength(10)]
        public string TelefonNr { get; set; }

        public int Bonuspoang { get; set; }
    }
}
