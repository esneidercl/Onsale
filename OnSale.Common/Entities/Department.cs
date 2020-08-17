using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnSale.Common.Entities
{
    public class Department // entidad de partamento
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "the file {0} must contain less than {1} characteres")]// asignar el numero de caracteres en la bd,error mesas para imprimir un mensaje al usuario
        [Required]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }// indicar coleccion de de ciudades relaccion

        [DisplayName("Cities Number")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;// propiedad de lectura


        /* [JsonIgnore]//requiere importa using Newtonsoft.Json;
         [NotMapped]// para que no aparezca en la bd
         public int IdCities { get; set; }*/
        [JsonIgnore]
        [NotMapped]
        public int IdCountry { get; set; }

    }

}
