using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CurriculumVitae.Models;

namespace CurriculumVitae.Controllers
{
	public class HomeController : Controller
	{
		public static string ShowResume()
		{
			using (ResumeContext context = new ResumeContext())
			{
				var resume1 = (from cil in context.ContactInformationLists select cil).ToString();
				var resume2 = (from el in context.EducationLists select el).ToString();
				var resume3 = (from pil in context.PersonalIntroductionLists select pil).ToString();
				var resume4 = (from pql in context.PersonalQualitiesLists select pql).ToString();
				var resume5 = (from ppl in context.PortfolioProjectsLists select ppl).ToString();
				var resume6 = (from pll in context.ProgrammingLanguagesLists select pll).ToString();
				var resume7 = (from ptl in context.ProgrammingToolsLists select ptl).ToString();
				var resume8 = (from we in context.WorkExperienceLists select we).ToString();
				var resume = resume1 + resume2 + resume3 + resume4 + resume5 + resume6 + resume7 + resume8;

				return resume;
			}
		}
	}
}