﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/security/v1")]
    [ApiController]
    public class SecurityLoginsRoleController : ControllerBase
    {
       
            private readonly SecurityLoginsRoleLogic _logic;

            public SecurityLoginsRoleController()
            {
                var repo = new EFGenericRepository<SecurityLoginsRolePoco>();
                _logic = new SecurityLoginsRoleLogic(repo);
            }

            [HttpGet]
            [Route("loginsrole/{id}")]
            public ActionResult GetSecurityLoginsRole(Guid id)
            {
                SecurityLoginsRolePoco poco = _logic.Get(id);
                if (poco == null)
                {
                    return NotFound();
                }
                return Ok(poco);
            }
            [HttpGet]
            [Route("loginsrole")]
            public ActionResult GetAllSecurityLoginRole()
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
            [Route("loginsrole")]
            public ActionResult PostSecurityLoginRole([FromBody] SecurityLoginsRolePoco[] appEduPocos)
            {
                _logic.Add(appEduPocos);
                return Ok();
            }

            [HttpPut]
            [Route("loginsrole")]
            public ActionResult PutSecurityLoginRole([FromBody] SecurityLoginsRolePoco[] pocos)
            {
                _logic.Update(pocos);
                return Ok();
            }

            [HttpDelete]
            [Route("loginsrole")]
            public ActionResult DeleteSecurityLoginRole([FromBody] SecurityLoginsRolePoco[] pocos)
            {
                _logic.Delete(pocos);
                return Ok();
            }

        }
    }