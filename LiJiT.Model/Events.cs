using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiJiT.Model
{
    public class Events : AuditableEntity<int>
    {
        [StringLength(150)]
        public string Note { get; set; }
        [StringLength(200)]
        [Required]
        public string Address { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string Location { get; set; }

        [ForeignKey("StatusTypeId")]
        public Int16 StatusTypeId { get; set; }
        public virtual StatusType StatusType { get; set; }


    }
}
