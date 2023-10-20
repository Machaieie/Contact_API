using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contacto.Model
{
    [Table("Contacto")]
    public class ContactoModelo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string? Contacto { get; set;}

        [Required]
        [StringLength(50)]
        public string? Email { get; set;}

        public ContactoModelo(int id, string? nome, string? contacto, string? email)
        {
            this.Id = id;
            this.Nome = nome;
            this.Contacto = contacto;
            this.Email = email;
        }
    }
}
