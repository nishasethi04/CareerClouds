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
using static CareerCloud.gRPC.Protos.CompanyJobEducation;

namespace CareerCloud.gRPC.Services
{
    public class CompanyJobEducationService : CompanyJobEducationBase
    {
        private readonly CompanyJobEducationLogic _logic;
        public CompanyJobEducationService()
        {
            var repo = new EFGenericRepository<CompanyJobEducationPoco>();
            _logic = new CompanyJobEducationLogic(repo);
        }

        public override Task<CompanyJobEducationPayload> ReadCompanyJobEducation(IdRequestEducation request, ServerCallContext context)
        {
            CompanyJobEducationPoco poco = new CompanyJobEducationPoco();

            return new Task<CompanyJobEducationPayload>(() => new CompanyJobEducationPayload()
            {
                 Id = poco.Id.ToString(),
            Job = poco.Job.ToString(),
             Major = poco.Major,
             Importance = poco.Importance


        });

            

           
        }
        public override Task<Empty> CreateCompanyJobEducation(CompanyJobEducationPayload request, ServerCallContext context)
        {
            CompanyJobEducationPoco[] pocos = new CompanyJobEducationPoco[1];
            foreach(var poco in pocos)
            {

                poco.Id = Guid.Parse(request.Id);
                poco.Job = Guid.Parse(request.Job);
                poco.Major = request.Major;
                poco.Importance = Convert.ToInt16(request.Importance);

            }

            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());

        }
        public override Task<Empty> DeleteCompanyJobEducation(CompanyJobEducationPayload request, ServerCallContext context)
        {
            CompanyJobEducationPoco[] pocos = new CompanyJobEducationPoco[1];
            foreach (var poco in pocos)
            {

                poco.Id = Guid.Parse(request.Id);
                poco.Job = Guid.Parse(request.Job);
                poco.Major = request.Major;
                poco.Importance = Convert.ToInt16(request.Importance);

            }

            _logic.Update(pocos);
            return new Task<Empty>(() => new Empty());

        }
        public override Task<Empty> UpdateCompanyJobEducation(CompanyJobEducationPayload request, ServerCallContext context)
        {
            CompanyJobEducationPoco[] pocos = new CompanyJobEducationPoco[1];
            foreach (var poco in pocos)
            {

                poco.Id = Guid.Parse(request.Id);
                poco.Job = Guid.Parse(request.Job);
                poco.Major = request.Major;
                poco.Importance = Convert.ToInt16(request.Importance);

            }

            _logic.Delete(pocos);
            return new Task<Empty>(() => new Empty());

        }




    }
}
