using System.ComponentModel.DataAnnotations;

namespace EncuestaWeb
{
    public class Encuesta
    {
        [Required]
        [Display(Name = "Facultad")]
        public string Facultad { get; set; }

        [Required]
        [Display(Name = "Escuela Académico Profesional")]
        public string EscuelaProfesional { get; set; }

        [Required]
        [Display(Name = "Año Académico")]
        public int AñoAcademico { get; set; }

        [Required]
        [Display(Name = "Género")]
        public string Genero { get; set; }

        [Required]
        [Display(Name = "Año de Nacimiento")]
        public int AñoNacimiento { get; set; }

        [Required]
        [Display(Name = "Estado de Vivienda")]
        public string EstadoVivienda { get; set; }

        [Required]
        [Display(Name = "Planes de Vivienda")]
        public string PlanesVivienda { get; set; }

        [Required]
        [Display(Name = "Planes a Futuro")]
        public string PlanesFuturosEducacion { get; set; }

        [Required]
        [Display(Name = "Tiempo para Encontrar Trabajo")]
        public string TiempoParaEncontrarTrabajo { get; set; }

        [Required]
        [Display(Name = "Ingreso Anual")]
        public decimal IngresoAnual { get; set; }

    }
}
