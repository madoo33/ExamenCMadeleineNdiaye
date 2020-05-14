namespace ProjetGestionCom.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenom { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Telephone { get; set; }

        [Required]
        [StringLength(50)]
        public string Adresse { get; set; }
    }
}
