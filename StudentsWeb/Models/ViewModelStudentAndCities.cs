using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ShimiTest
{
    public class ViewModelStudentAndCities
    {
       
        [Required(ErrorMessage = "First Name is Requirde")]
        [RegularExpression(@"^[a-zA-Z]{2,20}$")]
        public string First_name_ { get; set; }

        [Required(ErrorMessage = "Last Name is Requirde")]
        [RegularExpression(@"^[a-zA-Z]{2,20}$")]
        public string Last_name_ { get; set; }

        [Required(ErrorMessage = "Date_of_birth is Requirde")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime Date_of_birth { get; set; }

        [RegularExpression(@"^\d{9}$", ErrorMessage = "Invalid id Number")]
        public string Israeli_ID_ { get; set; }

        public Nullable<int> CityId { get; set; }

        [StringLength(1000)]
        public string Description_ { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public City SelectedCity { get; set; }

    }
}

