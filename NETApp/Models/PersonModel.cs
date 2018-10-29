using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETApp.Models
{
    public class PersonModel
    {
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		public string Name { get; set; }
		public int EventCount { get; set; }

    }
}
