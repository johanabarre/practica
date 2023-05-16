using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgra.Entities
{
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        [MaxLength(30)]
        [Required]
        public string Nombre { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
