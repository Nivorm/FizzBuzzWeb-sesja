using System;
using System.ComponentModel.DataAnnotations;
using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Podaj rok urodzenia")]		
        [Required]
		[Range(1899, 2022, ErrorMessage = "Oczekiwano wartość z zakresu 1899-2022.")]
        public int? Number { get; set; }
		
		[Display(Name = "Podaj imie")]
		public string? Firstname { get; set; }
        public string numeric()
        {
            if(Number == null)
            {
				return "";
            }
            if (this.Number % 100 != 0 && this.Number % 4 == 0 || this.Number%400==0)
            {
                return "przestępny";
            }
            return "nieprzestępny";
        }
    }
}
