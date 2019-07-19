using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppMvc.Models
{
    public partial class Factura : IEntity
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTurno { get; set; }
        public Turno Turno { get; set; }
        public double Monto {get; set;}
        
        
    }

    [MetadataType(typeof(FacturaMetadata))]

    public partial class Factura
    {
        public class FacturaMetadata
        {
            [Key]
            [Column(Order = 1)]
            public int Id { get; set; }

            [ForeignKey("Turno")]
            [Column(Order = 2)]
            [Required]
            public int IdTurno { get; set; }
           
            [Required]
            public DateTime Fecha { get; set; }

            [Required]
            public Double Monto { get; set; }

        }
    }
}