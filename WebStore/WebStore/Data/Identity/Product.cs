using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Data.Identity
{
    [Table("Product", Schema = "data")]
    public class Product
    {
        public Guid Id { get; set; } 
        public string Name { get; set; } // Название товара
        public string Description { get; set; } // Описание товара
        public decimal Price { get; set; } // Цена товара
        public bool Explicit { get; set; }
        public string ImageUrl { get; set; } // Ссылка на изображение товара
        public DateTime CreatedAt { get; set; } // Дата добавления товара


    }
}
