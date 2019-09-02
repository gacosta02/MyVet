
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Document { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }
        [Required]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }
        public string Adress { get; set; }
        //propiedad de solo lectura
        //public string FullName {
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //     }
        public string FullNme => $"{FirstName} {LastName}";
        public string FullNameWithDocumente => $"{FirstName}{LastName}-{Document}";


    }
}
