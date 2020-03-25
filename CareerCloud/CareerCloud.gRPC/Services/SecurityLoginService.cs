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
using static CareerCloud.gRPC.Protos.SecurityLogin;

namespace CareerCloud.gRPC.Services
{
    public class SecurityLoginService : SecurityLoginBase
    {
        private readonly SecurityLoginLogic _logic;

        public SecurityLoginService()
        {
            _logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>());
        }

        public override Task<SecurityLoginPayload> ReadSecurityLogin(IdRequestSecurityLogin request, ServerCallContext context)
        {
            SecurityLoginPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<SecurityLoginPayload>(
                () => new SecurityLoginPayload()
                {
                    Id = poco.Id.ToString(),
                    Login = poco.Login,
                    Password = poco.Password,
                    Created = Timestamp.FromDateTime((DateTime)poco.Created),
                    PasswordUpdate = poco.PasswordUpdate is null ? null : Timestamp.FromDateTime((DateTime)poco.PasswordUpdate),
                    AgreementAccepted = poco.AgreementAccepted is null ? null : Timestamp.FromDateTime((DateTime)poco.AgreementAccepted),
                    IsLocked = poco.IsLocked,
                    IsInactive = poco.IsInactive,
                    EmailAddress = poco.EmailAddress,
                    PhoneNumber = poco.PhoneNumber,
                    FullName = poco.FullName,
                    ForceChangePassword = poco.ForceChangePassword,
                    PrefferredLanguage = poco.PrefferredLanguage
                });
        }
     

        public override Task<Empty> CreateSecurityLogin(SecurityLoginPayload request, ServerCallContext context)
        {
            SecurityLoginPoco[] pocos = new SecurityLoginPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Login = request.Login;
                poco.Password = request.Password;
                poco.Created = request.Created.ToDateTime();
                poco.PasswordUpdate = request.PasswordUpdate.ToDateTime();
                poco.AgreementAccepted = request.AgreementAccepted.ToDateTime();
                poco.IsLocked = request.IsLocked;
                poco.IsInactive = request.IsInactive;
                poco.EmailAddress = request.EmailAddress;
                poco.PhoneNumber = request.PhoneNumber;
                poco.FullName = request.FullName;
                poco.ForceChangePassword = request.ForceChangePassword;
            }
            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<Empty> DeleteSecurityLogin(SecurityLoginPayload request, ServerCallContext context)
        {
            SecurityLoginPoco[] pocos = new SecurityLoginPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Login = request.Login;
                poco.Password = request.Password;
                poco.Created = request.Created.ToDateTime();
                poco.PasswordUpdate = request.PasswordUpdate.ToDateTime();
                poco.AgreementAccepted = request.AgreementAccepted.ToDateTime();
                poco.IsLocked = request.IsLocked;
                poco.IsInactive = request.IsInactive;
                poco.EmailAddress = request.EmailAddress;
                poco.PhoneNumber = request.PhoneNumber;
                poco.FullName = request.FullName;
                poco.ForceChangePassword = request.ForceChangePassword;
            }
            _logic.Delete(pocos);
            return new Task<Empty>(() => new Empty());
        }

        public override Task<Empty> UpdateSecurityLogin(SecurityLoginPayload request, ServerCallContext context)
        {
            SecurityLoginPoco[] pocos = new SecurityLoginPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Login = request.Login;
                poco.Password = request.Password;
                poco.Created = request.Created.ToDateTime();
                poco.PasswordUpdate = request.PasswordUpdate.ToDateTime();
                poco.AgreementAccepted = request.AgreementAccepted.ToDateTime();
                poco.IsLocked = request.IsLocked;
                poco.IsInactive = request.IsInactive;
                poco.EmailAddress = request.EmailAddress;
                poco.PhoneNumber = request.PhoneNumber;
                poco.FullName = request.FullName;
                poco.ForceChangePassword = request.ForceChangePassword;
            }
            _logic.Update(pocos);
            return new Task<Empty>(() => new Empty());
        }
    }
}
