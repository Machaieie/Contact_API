using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contacto.Model
{
    [Table("Usuario")]
    public class UsuarioModelo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Senha { get; set; }

        public UsuarioModelo(int id, string? usuario, string? senha)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Senha = senha;
        }
    }
}
