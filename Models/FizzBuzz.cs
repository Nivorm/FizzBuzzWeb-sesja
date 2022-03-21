using System;
using System.ComponentModel.DataAnnotations;
using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required]
		[Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
		[NumberValidation(firstVar : 3, secondVar : 5)]
        public int? Number { get; set; }
        public bool numeric()
        {
            if(Number!= null)
            {
				return true;
            }
            else{
			    return false;
            }
        }
    }
}
