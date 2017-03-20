using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AttrubuteLearn.Models {
	public class CheckNameFormatAttribute:RegularExpressionAttribute {
		public CheckNameFormatAttribute():base("^[А-Яа-яЁёӘәҒғҚқҢңӨөҰұҮүҺһІі]+$") {
				
		}
	}
}