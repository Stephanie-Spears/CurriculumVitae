namespace CurriculumVitae.Migrations
{
	using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactInformationList",
                c => new
                    {
                        ContactSectionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Title = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        GitHub = c.String(),
                        LinkedIn = c.String(),
                        Homepage = c.String(),
                    })
                .PrimaryKey(t => t.ContactSectionId);
            
            CreateTable(
                "dbo.EducationList",
                c => new
                    {
                        EducationSectionId = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(),
                        Certification = c.String(),
                        Major = c.String(),
                        CompletionDate = c.DateTime(storeType: "date"),
                        CityState = c.String(),
                    })
                .PrimaryKey(t => t.EducationSectionId);
            
            CreateTable(
                "dbo.PersonalIntroductionList",
                c => new
                    {
                        IntroSectionId = c.Int(nullable: false, identity: true),
                        PersonalIntroduction = c.String(),
                    })
                .PrimaryKey(t => t.IntroSectionId);
            
            CreateTable(
                "dbo.PersonalQualitiesList",
                c => new
                    {
                        QualitiesSectionId = c.Int(nullable: false, identity: true),
                        PersonalQuality = c.String(),
                    })
                .PrimaryKey(t => t.QualitiesSectionId);
            
            CreateTable(
                "dbo.PortfolioProjectsList",
                c => new
                    {
                        ProjectSectionId = c.Int(nullable: false, identity: true),
                        ProjectTitle = c.String(),
                        ProjectDescription = c.String(),
                        ProjectRepo = c.String(),
                        ProjectDemo = c.String(),
                    })
                .PrimaryKey(t => t.ProjectSectionId);
            
            CreateTable(
                "dbo.ProgrammingLanguagesList",
                c => new
                    {
                        LanguageSectionId = c.Int(nullable: false, identity: true),
                        ProgrammingLanguage = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.LanguageSectionId);
            
            CreateTable(
                "dbo.ProgrammingToolsList",
                c => new
                    {
                        ToolSectionId = c.Int(nullable: false, identity: true),
                        ProgrammingTool = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ToolSectionId);
            
            CreateTable(
                "dbo.WorkExperienceList",
                c => new
                    {
                        WorkExperienceSectionId = c.Int(nullable: false, identity: true),
                        WorkTitle = c.String(),
                        Employer = c.String(),
                        WorkLocation = c.String(),
                        WorkDescription = c.String(),
                        StartDate = c.DateTime(storeType: "date"),
                        EndDate = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.WorkExperienceSectionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkExperienceList");
            DropTable("dbo.ProgrammingToolsList");
            DropTable("dbo.ProgrammingLanguagesList");
            DropTable("dbo.PortfolioProjectsList");
            DropTable("dbo.PersonalQualitiesList");
            DropTable("dbo.PersonalIntroductionList");
            DropTable("dbo.EducationList");
            DropTable("dbo.ContactInformationList");
        }
    }
}
