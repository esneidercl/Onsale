using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnSale.Common.Entities
{
    public class City // tabla de ciudad
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "the file {0} must contain less than {1} characteres")]// asignar el numero de caracteres en la bd,error mesas para imprimir un mensaje al usuario
        [Required]
        public string Name { get; set; }

        //public Department Department { get; set; } formas de crear una relacion

        [JsonIgnore]//requiere importa using Newtonsoft.Json; no altera la bd entonces no se requiere usar la consola del administrador de paquetes
        [NotMapped]// para que no aparezca en la bd
        public int IdDepartment { get; set; }


    }

}
