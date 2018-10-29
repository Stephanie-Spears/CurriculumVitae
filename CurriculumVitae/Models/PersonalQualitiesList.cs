namespace CurriculumVitae.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("PersonalQualitiesList")]
	public partial class PersonalQualitiesList
	{
		[Key]
		public int QualitiesSectionId { get; set; }

		public string PersonalQuality { get; set; }
	}
}