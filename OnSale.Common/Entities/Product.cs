using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OnSale.Common.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "the file {0} must contain less than {1} characteres")]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]// tex area drescripcion
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]// representacion de dinero con price
        public decimal Price { get; set; }

        [DisplayName("Is Active")]// boleano de actividad exitencia
        public bool IsActive { get; set; }

        [DisplayName("Is Starred")]// articulos destacados con estrellas
        public bool IsStarred { get; set; }

        public Category Category { get; set; }// 1 producto pertenece a una categoria

        public ICollection<ProductImage> ProductImages { get; set; }

        [DisplayName("Product Images Number")]
        public int ProductImagesNumber => ProductImages == null ? 0 : ProductImages.Count;// para saber cuantas imagenes tiene un producto

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ProductImages == null || ProductImages.Count == 0
            ? $"https://localhost:44390/images/noimage.png"
            : ProductImages.FirstOrDefault().ImageFullPath;
    }

}
