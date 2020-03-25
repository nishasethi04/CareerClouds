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
using static CareerCloud.gRPC.Protos.ApplicantWorkHistory;

namespace CareerCloud.gRPC.Services
{
    public class ApplicantWorkHistoryService : ApplicantWorkHistoryBase
    {
        private readonly ApplicantWorkHistoryLogic _logic;

        public ApplicantWorkHistoryService()
        {
            _logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>());
        }

        public override Task<Empty> CreateApplicantWorkHistory(ApplicantWorkHistoryPayload request, ServerCallContext context)
        {
            ApplicantWorkHistoryPoco[] pocos = new ApplicantWorkHistoryPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.CompanyName = request.CompanyName;
                poco.CountryCode = request.CountryCode;
                poco.Location = request.Location;
                poco.JobTitle = request.JobTitle;
                poco.JobDescription = request.JobDescription;
                poco.StartMonth = (short)request.StartMonth;
                poco.StartYear = request.StartYear;
                poco.EndMonth = (short)request.EndMonth;
                poco.EndYear = request.EndYear;
            }
            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<Empty> DeleteApplicantWorkHistory(ApplicantWorkHistoryPayload request, ServerCallContext context)
        {
            ApplicantWorkHistoryPoco[] pocos = new ApplicantWorkHistoryPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.CompanyName = request.CompanyName;
                poco.CountryCode = request.CountryCode;
                poco.Location = request.Location;
                poco.JobTitle = request.JobTitle;
                poco.JobDescription = request.JobDescription;
                poco.StartMonth = (short)request.StartMonth;
                poco.StartYear = request.StartYear;
                poco.EndMonth = (short)request.EndMonth;
                poco.EndYear = request.EndYear;
            }
            _logic.Delete(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<ApplicantWorkHistoryPayload> ReadApplicantWorkHistory(IdRequestHistory request, ServerCallContext context)
        {
            ApplicantWorkHistoryPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<ApplicantWorkHistoryPayload>(
                () => new ApplicantWorkHistoryPayload()
                {
                    Id = poco.Id.ToString(),
                    Applicant = poco.Applicant.ToString(),
                    CompanyName = poco.CompanyName,
                    CountryCode = poco.CountryCode,
                    Location = poco.Location,
                    JobTitle = poco.JobTitle,
                    JobDescription = poco.JobDescription,
                    StartMonth = poco.StartMonth,
                    StartYear = poco.StartYear,
                    EndMonth = poco.EndMonth,
                    EndYear = poco.EndYear
                });
        }
        

        public override Task<Empty> UpdateApplicantWorkHistory(ApplicantWorkHistoryPayload request, ServerCallContext context)
        {
            ApplicantWorkHistoryPoco[] pocos = new ApplicantWorkHistoryPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.CompanyName = request.CompanyName;
                poco.CountryCode = request.CountryCode;
                poco.Location = request.Location;
                poco.JobTitle = request.JobTitle;
                poco.JobDescription = request.JobDescription;
                poco.StartMonth = (short)request.StartMonth;
                poco.StartYear = request.StartYear;
                poco.EndMonth = (short)request.EndMonth;
                poco.EndYear = request.EndYear;
            }
            _logic.Update(pocos);
            return new Task<Empty>(() => new Empty());
        }
    }
}
