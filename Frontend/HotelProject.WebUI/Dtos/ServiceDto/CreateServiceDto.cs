using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Please fill out this field")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(100, ErrorMessage = "Max length for title is 100 characters.")]
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
    }
}
