using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CareerCloud.gRPC.Protos.CompanyProfile;

namespace CareerCloud.gRPC.Services
{
    public class CompanyProfileService : CompanyProfileBase
    {
        private readonly CompanyProfileLogic _logic;

        public CompanyProfileService()
        {
            _logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>());
        }

       
        public override Task<CompanyprofilePayload> ReadCompanyProfile(IdRequestCompanyProfile request, ServerCallContext context)
        {
            CompanyProfilePoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<CompanyprofilePayload>(
                () => new CompanyprofilePayload()
                {
                    Id = poco.Id.ToString(),
                    RegistrationDate = Timestamp.FromDateTime((DateTime)poco.RegistrationDate),
                    CompanyWebsite = poco.CompanyWebsite,
                    ContactPhone = poco.ContactPhone,
                    ContactName = poco.ContactName,
                    CompanyLogo = Google.Protobuf.ByteString.CopyFrom(poco.CompanyLogo)
                });
        }


        public override Task<Empty> CreateCompanyProfile(CompanyprofilePayload request, ServerCallContext context)
        {
            CompanyProfilePoco[] pocos = new CompanyProfilePoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.RegistrationDate = request.RegistrationDate.ToDateTime();
                poco.CompanyWebsite = request.CompanyWebsite;
                poco.ContactPhone = request.ContactPhone;
                poco.ContactName = request.ContactName;
                poco.CompanyLogo = request.CompanyLogo.ToByteArray();
            }
            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<Empty> DeleteCompanyProfile(CompanyprofilePayload request, ServerCallContext context)
        {
            CompanyProfilePoco[] pocos = new CompanyProfilePoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.RegistrationDate = request.RegistrationDate.ToDateTime();
                poco.CompanyWebsite = request.CompanyWebsite;
                poco.ContactPhone = request.ContactPhone;
                poco.ContactName = request.ContactName;
                poco.CompanyLogo = request.CompanyLogo.ToByteArray();
            }
            _logic.Delete(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<Empty> UpdateCompanyProfile(CompanyprofilePayload request, ServerCallContext context)
        {
            CompanyProfilePoco[] pocos = new CompanyProfilePoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.RegistrationDate = request.RegistrationDate.ToDateTime();
                poco.CompanyWebsite = request.CompanyWebsite;
                poco.ContactPhone = request.ContactPhone;
                poco.ContactName = request.ContactName;
                poco.CompanyLogo = request.CompanyLogo.ToByteArray();
            }
            _logic.Update(pocos);
            return new Task<Empty>(() => new Empty());
        }
    }
}
