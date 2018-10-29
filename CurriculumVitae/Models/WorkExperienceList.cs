namespace CurriculumVitae.Models
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("WorkExperienceList")]
	public partial class WorkExperienceList
	{
		[Key]
		public int WorkExperienceSectionId { get; set; }

		public string WorkTitle { get; set; }

		public string Employer { get; set; }

		public string WorkLocation { get; set; }

		public string WorkDescription { get; set; }

		[Column(TypeName = "date")]
		public DateTime? StartDate { get; set; }

		[Column(TypeName = "date")]
		public DateTime? EndDate { get; set; }
	}
}