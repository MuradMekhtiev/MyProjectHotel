using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public int RoomPrice { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        [StringLength(100, ErrorMessage = "Max length for title is 100 characters.")]

        public string RoomTitle { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoomBedCount { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoomBathCount { get; set; }

        public string Wifi { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoomDescription { get; set; }
    }
}
