using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "the file {0} must contain less than {1} characteres")]// asignar el numero de caracteres en la bd,error mesas para imprimir un mensaje al usuario
        [Required]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }// crear una imagen unica

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:5001/images/noimage.png"
            : $"https://onsale.blob.core.windows.net/categories/{ImageId}";
    }

}
