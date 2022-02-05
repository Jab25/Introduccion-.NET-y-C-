//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(AlumnosDataAnnotations))]

    public partial class Alumnos
    {
        public int id_alumnos { get; set; }
        public string nombre_alumno { get; set; }
        public string primerApellido_alumno { get; set; }
        public string segundoApellido_alumno { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string curp { get; set; }
        public Nullable<decimal> sueldo { get; set; }
        public int idEstadoOrigen { get; set; }
        public short idEstatus { get; set; }
    
        public virtual Estados Estados { get; set; }
        public virtual EstatusAlumnos EstatusAlumnos { get; set; }
    }

    public class AlumnosDataAnnotations
    {
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El {0} debe tener mínmo {2} y máximo {1} caracteres")]
        [Display(Name = "Nombre")]
        public string nombre_alumno { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(60, ErrorMessage = "La longitud max del {0} es {1}")]
        [MinLength(3, ErrorMessage = "La longitud min del {0} es {1}")]
        [Display(Name = "Apellido Paterno")]
        public string primerApellido_alumno { get; set; }

        public string segundoApellido_alumno { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Formato incorrecto, del correo")]
        public string correo { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression("[0-9]{10}$", ErrorMessage = "El {0} no tiene el formato")]
        public string telefono { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> fechaNacimiento { get; set; }

        [RegularExpression("[A-Z]{4}[0-9]{6}[H|M][A-Z]{2}[B-DF-HJ-NP-TV-Z]{3}[A-Z&amp;0-9]{2}$", ErrorMessage = "El {0} no tiene el formato")]
        public string curp { get; set; }

        public Nullable<decimal> sueldo { get; set; }
        
        public int idEstadoOrigen { get; set; }
        
        public short idEstatus { get; set; }
    }
}
