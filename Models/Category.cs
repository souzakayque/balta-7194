using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Esse campo deve ter entre 3 e 60 caracteres.")]
        [MinLength(3, ErrorMessage = "Esse campo deve ter entre 3 e 60 caracteres.")]
        [DataType("nvarchar")]
        public string Title { get; set; }
    }
}