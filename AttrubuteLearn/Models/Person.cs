using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AttrubuteLearn.Models {
	public class Person {
		[Required(ErrorMessage ="FirstName is null")]
		public string FirstName { get; set; }
		[CheckNameFormat(ErrorMessage ="Буквы должны быть русскими")]
		public string LastName { get; set; }
		[Range(0,120,ErrorMessage ="Возраст в диапазоне от 0 до 120")]
		public int Age { get; set; }
		[RegularExpression("^[А-Яа-яЁёӘәҒғҚқҢңӨөҰұҮүҺһІі]+$",ErrorMessage ="Буквы должны быть русскими")]
		public string Email { get; set; }
	}
}

//"^[А-Яа-яЁёӘәҒғҚқҢңӨөҰұҮүҺһІі]+$"
