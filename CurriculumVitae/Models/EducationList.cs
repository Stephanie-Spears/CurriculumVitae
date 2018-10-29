namespace CurriculumVitae.Models
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("EducationList")]
	public partial class EducationList
	{
		[Key]
		public int EducationSectionId { get; set; }

		public string SchoolName { get; set; }

		public string Certification { get; set; }

		public string Major { get; set; }

		[Column(TypeName = "date")]
		public DateTime? CompletionDate { get; set; }

		public string CityState { get; set; }
	}
}