using AutoMapper;
using Business_Logic_Layer.BOs;
using Data_Access_Layer;
using Data_Access_Layer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services
{
    public class AuthenticationService
    {
        public static InstitutionTokenModel Auth(InstitutionModel user)
        {
            var dbuser = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Institution>())).Map<Institution>(user);
            var createToken = DataAccess.GetInstitutionTokenDataAccess().Authenticate(dbuser);
            var returnToken = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<InstitutionToken, InstitutionTokenModel>())).Map<InstitutionTokenModel>(createToken);
            return returnToken;
        }

        public static bool CheckValidityToken(string token)
        {
            var x = DataAccess.GetInstitutionTokenDataAccess().IsAuthenticated(token);
            return x;
        }

        public static bool Logout(string token)
        {
            return DataAccess.GetInstitutionTokenDataAccess().Logout(token);
        }
    }
}
