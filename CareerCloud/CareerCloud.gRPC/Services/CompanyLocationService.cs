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
using static CareerCloud.gRPC.Protos.CompanyLocation;

namespace CareerCloud.gRPC.Services
{
    public class CompanyLocationService : CompanyLocationBase
    {
        private readonly CompanyLocationLogic _logic;

        public CompanyLocationService()
        {
            _logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>());

        }
        public override Task<CompanyLocationPayload> ReadCompanyLocation(IdRequestLocation request, ServerCallContext context)
        {
            CompanyLocationPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<CompanyLocationPayload>(
                () => new CompanyLocationPayload()
                {
                    Id = poco.Id.ToString(),
                    Company = poco.Company.ToString(),
                    CountryCode = poco.CountryCode,
                    Province = poco.Province,
                    Street = poco.Street,
                    City = poco.City,
                    PostalCode = poco.PostalCode
                });
        }
       
        public override Task<Empty> CreateCompanyLocation(CompanyLocationPayload request, ServerCallContext context)
        {
            CompanyLocationPoco[] pocos = new CompanyLocationPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Company = Guid.Parse(request.Company);
                poco.CountryCode = request.CountryCode;
                poco.Province = request.Province;
                poco.Street = request.Street;
                poco.City = request.City;
                poco.PostalCode = request.PostalCode;
            }
            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<Empty> DeleteCompanyLocation(CompanyLocationPayload request, ServerCallContext context)
        {
            CompanyLocationPoco[] pocos = new CompanyLocationPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Company = Guid.Parse(request.Company);
                poco.CountryCode = request.CountryCode;
                poco.Province = request.Province;
                poco.Street = request.Street;
                poco.City = request.City;
                poco.PostalCode = request.PostalCode;
            }
            _logic.Delete(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<Empty> UpdateCompanyLocation(CompanyLocationPayload request, ServerCallContext context)
        {
            CompanyLocationPoco[] pocos = new CompanyLocationPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Company = Guid.Parse(request.Company);
                poco.CountryCode = request.CountryCode;
                poco.Province = request.Province;
                poco.Street = request.Street;
                poco.City = request.City;
                poco.PostalCode = request.PostalCode;
            }
            _logic.Update(pocos);
            return new Task<Empty>(() => new Empty());
        }
    }
}
