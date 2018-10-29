namespace CurriculumVitae.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("ProgrammingToolsList")]
	public partial class ProgrammingToolsList
	{
		[Key]
		public int ToolSectionId { get; set; }

		[StringLength(50)]
		public string ProgrammingTool { get; set; }
	}
}