using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Faces.WebMvc.ViewModels
{
    public class OrderViewModel
    {
        [Display(Name = "Order ID")]
        public Guid OrderID { get; set; }

        [Display(Name = "Email")]
        public string UserEmail { get; set; }

        [Display(Name = "Image FIle")]
        public IFormFile File { get; set; }

        [Display(Name = "ImageUrl")]
        public string ImageUrl { get; set; }

        [Display(Name = "Order Status")]
        public string StatusString { get; set; }

        public byte[] ImageData { get; set; }
    }
}
