namespace CurriculumVitae.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("ContactInformationList")]
	public partial class ContactInformationList
	{
		[Key]
		public int ContactSectionId { get; set; }

		public string Name { get; set; }

		public string Title { get; set; }

		public string Mobile { get; set; }

		public string Email { get; set; }

		public string GitHub { get; set; }

		public string LinkedIn { get; set; }

		public string Homepage { get; set; }
	}
}