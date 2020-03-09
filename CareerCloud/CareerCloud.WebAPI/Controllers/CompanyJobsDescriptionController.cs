
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CareerCloud.WebAPI.Controllers;


namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/company/v1")]
    [ApiController]
    public class CompanyJobsDescriptionController : ControllerBase
    {
          private readonly CompanyJobDescriptionLogic _logic;

             public CompanyJobsDescriptionController()
             {
                 var repo = new EFGenericRepository<CompanyJobDescriptionPoco>();
                 _logic = new CompanyJobDescriptionLogic(repo);
             }

             [HttpGet]
             [Route("jobsdescription/{id}")]
             public ActionResult GetCompanyJobsDescription(Guid id)
             {
                 CompanyJobDescriptionPoco poco = _logic.Get(id);
                 if (poco == null)
                 {
                     return NotFound();
                 }
                 return Ok(poco);
             }
             [HttpGet]
             [Route("jobsdescription")]
             public ActionResult GetAllCompanyJobsDescription()
             {
                 var applicants = _logic.GetAll();
                 if (applicants == null)
                 {
                     return NotFound();
                 }
                 else
                     return Ok(applicants);
             }
             [HttpPost]
             [Route("jobsdescription")]
             public ActionResult PostCompanyJobsDescription([FromBody] CompanyJobDescriptionPoco[] appEduPocos)
             {
                 _logic.Add(appEduPocos);
                 return Ok();
             }

             [HttpPut]
             [Route("jobsdescription")]
             public ActionResult PutCompanyJobsDescription([FromBody] CompanyJobDescriptionPoco[] pocos)
             {
                 _logic.Update(pocos);
                 return Ok();
             }

             [HttpDelete]
             [Route("jobsdescription")]
             public ActionResult DeleteCompanyJobsDescription([FromBody] CompanyJobDescriptionPoco[] pocos)
             {
                 _logic.Delete(pocos);
                 return Ok();
             }
             
    }
}