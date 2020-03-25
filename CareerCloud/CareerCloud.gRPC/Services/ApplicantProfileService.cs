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
using static CareerCloud.gRPC.Protos.ApplicantProfile;

namespace CareerCloud.gRPC.Services
{
    public class ApplicantProfileService : ApplicantProfileBase
    {
        private readonly ApplicantProfileLogic _logic;

        public ApplicantProfileService()
        {
            _logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>());
        }

        public override Task<Empty> CreateApplicantProfile(ApplicantProfilePayload request, ServerCallContext context)
        {
            ApplicantProfilePoco[] pocos = new ApplicantProfilePoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Login = Guid.Parse(request.Login);
                poco.CurrentSalary = (decimal)request.CurrentSalary;
                poco.CurrentRate = (decimal)request.CurrentRate;
                poco.Currency = request.Currency;
                poco.Country = request.Country;
                poco.Province = request.Province;
                poco.Street = request.Street;
                poco.City = request.City;
                poco.PostalCode = request.PostalCode;
            }
            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());
        }
       
        public override Task<Empty> UpdateApplicantProfile(ApplicantProfilePayload request, ServerCallContext context)
        {
            ApplicantProfilePoco[] pocos = new ApplicantProfilePoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Login = Guid.Parse(request.Login);
                poco.CurrentSalary = (decimal)request.CurrentSalary;
                poco.CurrentRate = (decimal)request.CurrentRate;
                poco.Currency = request.Currency;
                poco.Country = request.Country;
                poco.Province = request.Province;
                poco.Street = request.Street;
                poco.City = request.City;
                poco.PostalCode = request.PostalCode;

            }
            _logic.Update(pocos);
            return new Task<Empty>(() => new Empty());
        }
        public override Task<ApplicantProfilePayload> ReadApplicantProfile(IdRequestProfile request, ServerCallContext context)
        {
            ApplicantProfilePoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<ApplicantProfilePayload>(
                () => new ApplicantProfilePayload()
                {
                    Id = poco.Id.ToString(),
                    Login = poco.Login.ToString(),
                    CurrentSalary = poco.CurrentSalary is null ? 0.00 : (double)poco.CurrentSalary,
                    CurrentRate = poco.CurrentRate is null ? 0.00 : (double)poco.CurrentRate,
                    Currency = poco.Currency,
                    Country = poco.Country,
                    Province = poco.Province,
                    Street = poco.Street,
                    City = poco.City,
                    PostalCode = poco.PostalCode
                });
        }
      

        public override Task<Empty> DeleteApplicantProfile(ApplicantProfilePayload request, ServerCallContext context)
        {
            ApplicantProfilePoco[] app_pocos = new ApplicantProfilePoco[1];
            foreach (var poco in app_pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Login = Guid.Parse(request.Login);
                poco.CurrentSalary = (decimal)request.CurrentSalary;
                poco.CurrentRate = (decimal)request.CurrentRate;
                poco.Currency = request.Currency;
                poco.Country = request.Country;
                poco.Province = request.Province;
                poco.Street = request.Street;
                poco.City = request.City;
                poco.PostalCode = request.PostalCode;
            }
            _logic.Delete(app_pocos);
            return new Task<Empty>(() => new Empty());
        }
    }
}
