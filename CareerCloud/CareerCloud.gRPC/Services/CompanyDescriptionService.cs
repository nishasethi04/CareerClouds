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
using static CareerCloud.gRPC.Protos.CompanyDescription;
using static CareerCloud.gRPC.Protos.CompanyDescription.CompanyDescriptionBase;

namespace CareerCloud.gRPC.Services
{
    public class CompanyDescriptionService : CompanyDescriptionBase
    {
        private readonly CompanyDescriptionLogic _logic;

        public CompanyDescriptionService()
        {
            _logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>());
        }
        public override Task<Empty> CreateCompanyDescription(CompanyDescriptionPayload request, ServerCallContext context)
        {
            CompanyDescriptionPoco[] pocos = new CompanyDescriptionPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Company = Guid.Parse(request.Company);
                poco.LanguageId = request.LanguageId;
                poco.CompanyName = request.CompanyName;
                poco.CompanyDescription = request.CompanyDescription;
            }
            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());
        }

       

        public override Task<Empty> DeleteCompanyDescription(CompanyDescriptionPayload request, ServerCallContext context)
        {
            CompanyDescriptionPoco[] pocos = new CompanyDescriptionPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Company = Guid.Parse(request.Company);
                poco.LanguageId = request.LanguageId;
                poco.CompanyName = request.CompanyName;
                poco.CompanyDescription = request.CompanyDescription;
            }
            _logic.Delete(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<CompanyDescriptionPayload> ReadCompanyDescription(IdRequestDescription request, ServerCallContext context)
        {
            CompanyDescriptionPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<CompanyDescriptionPayload>(
                () => new CompanyDescriptionPayload()
                {
                    Id = poco.Id.ToString(),
                    Company = poco.Company.ToString(),
                    LanguageId = poco.LanguageId,
                    CompanyName = poco.CompanyName,
                    CompanyDescription = poco.CompanyDescription
                });
        }
        

        public override Task<Empty> UpdateCompanyDescription(CompanyDescriptionPayload request, ServerCallContext context)
        {
            CompanyDescriptionPoco[] pocos = new CompanyDescriptionPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Company = Guid.Parse(request.Company);
                poco.LanguageId = request.LanguageId;
                poco.CompanyName = request.CompanyName;
                poco.CompanyDescription = request.CompanyDescription;
            }
            _logic.Update(pocos);
            return new Task<Empty>(() => new Empty());
        }
    }
}
