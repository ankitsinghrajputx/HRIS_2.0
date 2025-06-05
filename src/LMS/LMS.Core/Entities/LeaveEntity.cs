using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Entities
{
    public class LeaveEntity
    {
        [Key]
        public Guid LeaveId { get; set; }

        [Required]
        [StringLength(10)]
        public required string LeaveCode { get; set; }

        [Required]
        [StringLength(50)]
        public required string LeaveName { get; set; }

        [StringLength(200)]
        public string? LeaveDescription { get; set; }

        [StringLength(20)]
        public string? LeaveType { get; set; }  // e.g., Paid, Unpaid

        public int? MaxDaysPerYear { get; set; }

        [Required]
        public bool IsCarryForward { get; set; }

        [Required]
        public bool IsEncashable { get; set; }

        [StringLength(20)]
        public string? CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(20)]
        public string? ModifiedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
