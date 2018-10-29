namespace CurriculumVitae.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("PersonalIntroductionList")]
	public partial class PersonalIntroductionList
	{
		[Key]
		public int IntroSectionId { get; set; }

		public string PersonalIntroduction { get; set; }
	}
}