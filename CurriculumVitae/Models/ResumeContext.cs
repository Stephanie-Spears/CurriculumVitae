namespace CurriculumVitae.Models
{
	using System.Data.Entity;

	public partial class ResumeContext : DbContext
	{
		public ResumeContext()
			: base("name=ResumeContext")
		{
		}

		public virtual DbSet<ContactInformationList> ContactInformationLists { get; set; }

		public virtual DbSet<EducationList> EducationLists { get; set; }
		public virtual DbSet<PersonalIntroductionList> PersonalIntroductionLists { get; set; }
		public virtual DbSet<PersonalQualitiesList> PersonalQualitiesLists { get; set; }
		public virtual DbSet<PortfolioProjectsList> PortfolioProjectsLists { get; set; }
		public virtual DbSet<ProgrammingLanguagesList> ProgrammingLanguagesLists { get; set; }
		public virtual DbSet<ProgrammingToolsList> ProgrammingToolsLists { get; set; }
		public virtual DbSet<WorkExperienceList> WorkExperienceLists { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}