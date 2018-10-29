using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CurriculumVitae.Models;

namespace CurriculumVitae.Controllers
{
	public class ResumeController : Controller
	{
		public ResumeContext context = new ResumeContext();

		public ActionResult Index()
		{
			ViewData["ContactInformationList"] = from c in context.ContactInformationLists select c;
			ViewData["EducationList"] = from el in context.EducationLists select el;
			ViewData["PersonalIntroductionList"] = from pi in context.PersonalIntroductionLists select pi;
			ViewData["PersonalQualitiesList"] = from pq in context.PersonalQualitiesLists select pq;
			ViewData["PortfolioProjectsList"] = from pp in context.PortfolioProjectsLists select pp;
			ViewData["ProgrammingLanguagesList"] = from pl in context.ProgrammingLanguagesLists select pl;
			ViewData["ProgrammingToolsList"] = from pt in context.ProgrammingToolsLists select pt;
			ViewData["WorkExperienceList"] = from we in context.WorkExperienceLists select we;
			return View();
		}
	}
}