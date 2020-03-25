﻿using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CareerCloud.gRPC.Protos.CompanyJobDescription;

namespace CareerCloud.gRPC.Services
{
    public class CompanyJobDescriptionService:CompanyJobDescriptionBase
    {
        private readonly CompanyJobDescriptionLogic _logic;
        public CompanyJobDescriptionService()
        {
            _logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>());
        }

        public override Task<CompanyJobDescriptionPayload> ReadCompanyJobDescription(IdRequestJobDescription request, ServerCallContext context)
        {
            CompanyJobDescriptionPoco poco = _logic.Get(Guid.Parse(request.Id));

            return new Task<CompanyJobDescriptionPayload>(() => new CompanyJobDescriptionPayload()
            {

                Id = poco.Id.ToString(),
                Job = poco.Job.ToString(),
                JobName = poco.JobName,
                JobDescriptions = poco.JobDescriptions


            });

        }
        public override Task<Empty> CreateCompanyJobDescription(CompanyJobDescriptionPayload request, ServerCallContext context)
        {

            CompanyJobDescriptionPoco[] pocos = new CompanyJobDescriptionPoco[1];
            foreach(var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Job = Guid.Parse(request.Job);
                poco.JobName = request.JobName;
                poco.JobDescriptions = request.JobDescriptions;

            }
            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());
            
        }

        public override Task<Empty> UpdateCompanyJobDescription(CompanyJobDescriptionPayload request, ServerCallContext context)
        {
            CompanyJobDescriptionPoco[] pocos = new CompanyJobDescriptionPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Job = Guid.Parse(request.Job);
                poco.JobName = request.JobName;
                poco.JobDescriptions = request.JobDescriptions;

            }
            _logic.Update(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<Empty> DeleteCompanyJobDescription(CompanyJobDescriptionPayload request, ServerCallContext context)
        {
            CompanyJobDescriptionPoco[] pocos = new CompanyJobDescriptionPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Job = Guid.Parse(request.Job);
                poco.JobName = request.JobName;
                poco.JobDescriptions = request.JobDescriptions;

            }
            _logic.Delete(pocos);
            return new Task<Empty>(() => new Empty());
        }

    }
    
}
