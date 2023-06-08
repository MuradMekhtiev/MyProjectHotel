using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(100, ErrorMessage = "Max length for title is 100 characters.")]
        public string ServiceTitle { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(500, ErrorMessage = "Max length for title is 500 characters.")]
        public string ServiceDescription { get; set; }
    }
}
