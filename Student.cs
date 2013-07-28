using System;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Model
{
	public class Student
	{
		[Key]
		[MaxLength(10)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }

		[Required]
		[MaxLength(50)]
		public string LastName { get; set; }

		[Required]
		public DateTime DateOfBirth { get; set; }
	}
}
