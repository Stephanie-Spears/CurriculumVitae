namespace CurriculumVitae.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("ProgrammingLanguagesList")]
	public partial class ProgrammingLanguagesList
	{
		[Key]
		public int LanguageSectionId { get; set; }

		[StringLength(50)]
		public string ProgrammingLanguage { get; set; }
	}
}