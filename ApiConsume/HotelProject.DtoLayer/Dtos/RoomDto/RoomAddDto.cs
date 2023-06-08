using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public int RoomPrice { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoomTitle { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoomBedCount { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoomBathCount { get; set; }
        public string Wifi { get; set; }
        public string RoomDescription { get; set; }
    }
}
