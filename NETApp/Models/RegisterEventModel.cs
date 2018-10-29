using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETApp.Models
{
    public class EventModel
    {

		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Location { get; set; }
		public DateTime DateTime { get; set; }
		public string Details { get; set; }
	}

	public class RegisterEventModel
	{
		[Required]
		[Display(Name = "ID")]
		public string ID { get; set; }

		[Required]
		[Display(Name = "Name")]
		public string Name { get; set; }

		[Required]
		[Display(Name = "Location")]
		public string Location { get; set; }

		[Required]
		[Display(Name = "DateTime")]
		public DateTime DateTime { get; set; }

		[Display(Name = "Details")]
		public string Details { get; set; }
	}



}


