﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using CareerCloud.BusinessLogicLayer;
//using CareerCloud.EntityFrameworkDataAccess;
//using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic:BaseLogic<CompanyProfilePoco>
    {
        public CompanyProfileLogic( IDataRepository<CompanyProfilePoco> repository):base(repository)
        {
            
        }
        protected override void Verify(CompanyProfilePoco[] pocos)
        {
        /*    List<ValidationException> exceptions = new List<ValidationException>();

            foreach (CompanyProfilePoco poco in pocos)
            {

                if (string.IsNullOrEmpty(poco.CompanyWebsite))
                {
                    exceptions.Add(new ValidationException(600, $"Website is required"));
                }
                else
                {
                    string[] Websiteextensions = poco.CompanyWebsite.Split('.');
                    if (!String.Equals(Websiteextensions, "ca"))
                    {
                        exceptions.Add(new ValidationException(600, $"Website extension can be either ca,com or biz"));
                    }
                    else if (!String.Equals(Websiteextensions, "com"))
                    {
                        exceptions.Add(new ValidationException(600, $"Website extension can be either ca,com or biz"));
                    }
                    else if (!String.Equals(Websiteextensions, "biz"))
                    {
                        exceptions.Add(new ValidationException(600, $"Website extension can be either ca,com or biz"));
                    }
                }
                if (string.IsNullOrEmpty(poco.ContactPhone))
                {
                    exceptions.Add(new ValidationException(601, $"Contact phone is required"));
                }
                else
                {
                    string[] phoneComponents = poco.ContactPhone.Split('-');
                    if (phoneComponents.Length != 3)
                    {
                        exceptions.Add(new ValidationException(601, $"PhoneNumber for Company profile is not in the required format."));
                    }
                    else
                    {
                        if (phoneComponents[0].Length != 3)
                        {
                            exceptions.Add(new ValidationException(601, $"PhoneNumber for Company profile is not in the required format"));
                        }
                        else if (phoneComponents[1].Length != 3)
                        {
                            exceptions.Add(new ValidationException(601, $"PhoneNumber for Company profile is not in the required format"));
                        }
                        else if (phoneComponents[2].Length != 4)
                        {
                            exceptions.Add(new ValidationException(601, $"PhoneNumber for Company profile is not in the required format"));
                        }

                    }
                }
            }
            if(exceptions.Count>0)
            {
                throw new AggregateException(exceptions);
            }
            else
            {
                Console.WriteLine("This is OK"); ;
            }
        }*/
        List<ValidationException> exceptions = new List<ValidationException>();
        string[] requiredextenction = new string[] { ".ca", ".com", ".biz" };
            foreach (CompanyProfilePoco item in pocos)
            {
                if (item.CompanyWebsite != null && !requiredextenction.Any(t => item.CompanyWebsite.Contains(t)))
                {
                    exceptions.Add(new ValidationException(600, $"Website extension can be either ca,com or biz"));
                        
                }

                if ((item.ContactPhone == null)|| (item.ContactPhone!=null && !Regex.IsMatch(item.ContactPhone, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", RegexOptions.IgnoreCase)))
                {
                    exceptions.Add(new ValidationException(601, $"PhoneNumber for Company profile is not in the required format."));
                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }

        }
        public override void Update(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        public override void Add(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

    }
}
