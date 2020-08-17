using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace OnSale.Common.Entities
{
   public class Country
    {
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage ="the file {0} must contain less than {1} characteres")]// asignar el numero de caracteres en la bd,error mesas para imprimir un mensaje al usuario
        [Required]// para hacer que un campo sea requerido, se requiere importar paquete con alt+ enter
        public string Name{ get; set; }

        public ICollection<Department> Departments { get; set; }

        [DisplayName("Departments Number")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;

    }
}
