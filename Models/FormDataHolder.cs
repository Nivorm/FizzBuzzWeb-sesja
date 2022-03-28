using System;
using System.ComponentModel.DataAnnotations;
using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Models
{
    public class FormDataHolder
    {
        [Display(Name = "Podaj rok urodzenia")]		
        [Required]
		[Range(1899, 2022, ErrorMessage = "Oczekiwano wartość z zakresu 1899-2022.")]
        [LeapYear(firstVar : 4, secondVar : 100, thirdVar : 400)]
        public int? Number { get; set; }
		
        [Required]
		[Display(Name = "Podaj imie")]
        [StringLength(maximumLength:100, ErrorMessage = "Wpisano zbyt długie imię")]
		public string? Firstname { get; set; }
        public bool numeric()
        {
            if(Number!= null)
            {
				return true;
            }
            else
            {
			    return false;
            }
        }
    }
}
