using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models
{
    public class ShipperViewModel
    {
        [DisplayName("ID")]
        public int ShipperId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Nombre es requerido")]
        public string CompanyName { get; set; } = null!;
    }
}
