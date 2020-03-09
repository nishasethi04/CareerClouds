﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyJobDescriptionLogic:BaseLogic<CompanyJobDescriptionPoco>
    {
        public CompanyJobDescriptionLogic(IDataRepository<CompanyJobDescriptionPoco> repository) : base(repository)
        {
            
        }
        public override void Add(CompanyJobDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(CompanyJobDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        protected override void Verify(CompanyJobDescriptionPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (CompanyJobDescriptionPoco poco in pocos)
            {
                if(String.IsNullOrEmpty(poco.JobName))
                {
                    exceptions.Add(new ValidationException(300, "You must provide Job Name"));
                }
                if(String.IsNullOrEmpty(poco.JobDescriptions))
                {
                    exceptions.Add(new ValidationException(301, "You must provide Job Description"));
                }
            }
            if(exceptions.Count>0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
