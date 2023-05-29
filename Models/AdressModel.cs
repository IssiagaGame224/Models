using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibApp.Models
{
	public class AdressModel
	{
		[Required(ErrorMessage = "La rue doit être saisie")]
		[StringLength(128, MinimumLength = 3, ErrorMessage = "La rue doit être comprise entre 3 et 128 caractères")]
		public string Street { get; set; }

		public string Zipcode { get; set; }

		[Required(ErrorMessage = "La selection d'un pays est obligatoire")]
		public Country Country { get; set; }
	}
}
