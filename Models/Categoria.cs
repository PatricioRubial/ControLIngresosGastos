using System.ComponentModel.DataAnnotations;


namespace ControLIngresosGastos.Models
{
    public class Categoria

    {[Key]
        public int Id { get; set; }

        [Required]

        [MaxLength(120)]
        [Display(Name = "Nombre Categoria")]
        public string NombreCategoria { get; set; }

        [Required]
        [MaxLength(2)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } //IN ingreso Ga Gasto

        public bool Estado { get; set; } // true , False


    }
             
}


