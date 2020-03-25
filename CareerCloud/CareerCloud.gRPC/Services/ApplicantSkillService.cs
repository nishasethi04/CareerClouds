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
using static CareerCloud.gRPC.Protos.ApplicantSkill;

namespace CareerCloud.gRPC.Services
{
    public class ApplicantSkillService : ApplicantSkillBase
    {
        private readonly ApplicantSkillLogic _logic;

        public ApplicantSkillService()
        {
            _logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>());
        }

        public override Task<Empty> CreateApplicantSkill(ApplicantSkillPayload request, ServerCallContext context)
        {
            ApplicantSkillPoco[] pocos = new ApplicantSkillPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.Skill = request.Skill;
                poco.SkillLevel = request.SkillLevel;
                poco.StartMonth = (byte)request.StartMonth;
                poco.StartYear = (byte)request.StartYear;
                poco.EndMonth = (byte)request.EndMonth;
                poco.EndYear = request.EndYear;
            }
            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<Empty> DeleteApplicantSkill(ApplicantSkillPayload request, ServerCallContext context)
        {
            ApplicantSkillPoco[] pocos = new ApplicantSkillPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.Skill = request.Skill;
                poco.SkillLevel = request.SkillLevel;
                poco.StartMonth = (byte)request.StartMonth;
                poco.StartYear = (byte)request.StartYear;
                poco.EndMonth = (byte)request.EndMonth;
                poco.EndYear = request.EndYear;
            }
            _logic.Delete(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<ApplicantSkillPayload> ReadApplicantSkill(IdRequestSkill request, ServerCallContext context)
        {
            ApplicantSkillPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<ApplicantSkillPayload>(
                () => new ApplicantSkillPayload()
                {
                    Id = poco.Id.ToString(),
                    Applicant = poco.Applicant.ToString(),
                    Skill = poco.Skill,
                    SkillLevel = poco.SkillLevel,
                    StartMonth = poco.StartMonth,
                    StartYear = poco.StartYear,
                    EndMonth = poco.EndMonth,
                    EndYear = poco.EndYear
                });
        }
        
        public override Task<Empty> UpdateApplicantSkill(ApplicantSkillPayload request, ServerCallContext context)
        {
            ApplicantSkillPoco[] app_poco = new ApplicantSkillPoco[1];
            foreach (var poco in app_poco)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.Skill = request.Skill;
                poco.SkillLevel = request.SkillLevel;
                poco.StartMonth = (byte)request.StartMonth;
                poco.StartYear = (byte)request.StartYear;
                poco.EndMonth = (byte)request.EndMonth;
                poco.EndYear = request.EndYear;
            }
            _logic.Update(app_poco);
            return new Task<Empty>(() => new Empty());
        }
    }
}
