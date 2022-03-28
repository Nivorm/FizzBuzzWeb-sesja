// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;

// namespace FizzBuzzWeb.Models
// {
//     public class NumberValidation : ValidationAttribute
// 	{
//         private int firstVar, secondVar, thirdVar;
// 		public NumberValidation(int firstVar, int secondVar, int thirdVar)
// 		{
// 		    this.firstVar = firstVar;
// 		    this.secondVar = secondVar;
// 			this.thirdVar = thirdVar;
// 		}
// 		public override bool IsValid(object? value)
// 		{
// 			if (value == null)
// 			{
// 				return true;
// 			}
// 			int number = (int)value;

// 			if ((number % firstVar  == 0) && (number % secondVar != 0) || (number % thirdVar == 0))
// 			{
// 				ErrorMessage = "Przestępny";
// 				return false;
// 			}
// 			else
// 			{
// 				ErrorMessage = "Nieprzestępny";
// 				return false;
// 			}
// 			ErrorMessage = "Liczba " + number + " nie spelnia kryteriow co do roku";
// 			return false;
// 		}
// 	}
// }
