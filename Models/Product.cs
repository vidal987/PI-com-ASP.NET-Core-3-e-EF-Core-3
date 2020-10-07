using System.ComponentModel.DataAnnotations;

namespace projeto1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "3 e 60 caracteres")]  
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Esse campo deve conter no maximo 1024 caractertes")]
        public string Description { get; set; }

        [Required(ErrorMessage = "este campo é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior do que 0")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "este campo é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "categoria invalida")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}