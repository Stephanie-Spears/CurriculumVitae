namespace CurriculumVitae.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("PortfolioProjectsList")]
	public partial class PortfolioProjectsList
	{
		[Key]
		public int ProjectSectionId { get; set; }

		public string ProjectTitle { get; set; }

		public string ProjectDescription { get; set; }

		public string ProjectRepo { get; set; }

		public string ProjectDemo { get; set; }
	}
}