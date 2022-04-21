using System.ComponentModel.DataAnnotations;

namespace Leave_Management.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(0,15, ErrorMessage ="Please enter a valid number")]
        public int DefaultDays { get; set; }
    }
}
