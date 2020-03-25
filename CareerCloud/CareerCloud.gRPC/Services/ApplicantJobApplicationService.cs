using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CareerCloud.gRPC.Protos.ApplicantEducation;
using Google.Protobuf.WellKnownTypes;
using static CareerCloud.gRPC.Protos.ApplicantJobApplication;

namespace CareerCloud.gRPC.Services
{
    public class ApplicantJobApplicationService : ApplicantJobApplicationBase

    {
        private readonly ApplicantJobApplicationLogic _logic;
        public ApplicantJobApplicationService()
        {
            //var repo = new ApplicantJobApplicationPoco();
            _logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>());
        }

        public override Task<ApplicantJobApplicationPayload> ReadApplicantJobApplication(IdRequestJobApplication request, ServerCallContext context)
        {
            ApplicantJobApplicationPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<ApplicantJobApplicationPayload>(() => new ApplicantJobApplicationPayload()
            {
                Id = poco.Id.ToString(),
                Applicant = poco.Applicant.ToString(),
                Job = poco.Job.ToString(),
                ApplicationDate = poco.ApplicationDate == null ? null : Timestamp.FromDateTime((DateTime)poco.ApplicationDate)
                //CertificateDiploma = poco.CertificateDiploma,
                //CompletionDate = poco.CompletionDate is null ? null : Timestamp.FromDateTime((DateTime)poco.CompletionDate),
                //StartDate = poco.StartDate is null ? null : Timestamp.FromDateTime((DateTime)poco.StartDate),
                //CompletionPercent = poco.CompletionPercent is null ? 0 : (int)poco.CompletionPercent,
                //Major = poco.Major,

            });
        }

        public override Task<Empty> CreateApplicantJobApplication(ApplicantJobApplicationPayload request, ServerCallContext context)
        {
            ApplicantJobApplicationPoco[] pocos = new ApplicantJobApplicationPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.Job = Guid.Parse(request.Job);
                poco.ApplicationDate = request.ApplicationDate.ToDateTime();
            }
            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());

            //return base.CreateApplicantJobApplication(request, context);
        }

        public override Task<Empty> UpdateApplicantJobApplication(ApplicantJobApplicationPayload request, ServerCallContext context)
        {
            ApplicantJobApplicationPoco[] pocos = new ApplicantJobApplicationPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.Job = Guid.Parse(request.Job);
                poco.ApplicationDate = request.ApplicationDate.ToDateTime();
            }
            _logic.Update(pocos);
            return new Task<Empty>(() => new Empty());



            //return base.UpdateApplicantJobApplication(request, context);
        }

        public override Task<Empty> DeleteApplicantJobApplication(ApplicantJobApplicationPayload request, ServerCallContext context)
        {


            ApplicantJobApplicationPoco[] pocos = new ApplicantJobApplicationPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.Job = Guid.Parse(request.Job);
                poco.ApplicationDate = request.ApplicationDate.ToDateTime();
            }
            _logic.Delete(pocos);
            return new Task<Empty>(() => new Empty());
            //return base.DeleteApplicantJobApplication(request, context);
        }

    }
}
   
