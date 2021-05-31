using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppHochstetler.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name.")]
        public String LastName { get; set; }
        [Required(ErrorMessage = "Please select a date for your birthday.")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        public int? AgeToday()
        {
            int currentAge = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                currentAge -= 1;
            }
            return currentAge;
        }
    }
}
