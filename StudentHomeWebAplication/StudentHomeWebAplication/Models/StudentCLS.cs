using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentHomeWebAplication.Models
{
    public class StudentCLS
    {
        [Display(Name = "Id Student")]
        public long idStudent { get; set; }
        [Display(Name = "Nombre")]
        public string firstname { get; set; }
        [Display(Name = "Apellido")]
        public string lastname { get; set; }
        [Display(Name = "DNI")]
        public string DNI { get; set; }
        [Display(Name = "Departamento")]
        public int idRegion { get; set; }
        [Display(Name = "Provincia")]
        public int idProvince { get; set; }
        [Display(Name = "Distrito")]
        public int idDistrict { get; set; }
        [Display(Name = "Direccion")]
        public string addres { get; set; }
        [Display(Name = "Telefono")]
        public string phone { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        public DateTime birthdate { get; set; }
        [Display(Name = "Correo")]
        public string email { get; set; }
        [Display(Name = "Centro de estudio")]
        public string studyCenter { get; set; }
        [Display(Name = "Año de graduación")]
        public int graduationYear { get; set; }

        public int idPet { get; set; }

        public long idLifeStyle { get; set; }
    }
}