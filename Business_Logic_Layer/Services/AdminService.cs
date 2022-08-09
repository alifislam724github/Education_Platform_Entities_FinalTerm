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
    public class AdminService
    {

        public static List<AdminModel> Get1()
        {
            var data = DataAccess.GetAdminDataAccess().Get();
            var rdata = new List<AdminModel>();
            foreach (var item in data)
            {
                rdata.Add(new AdminModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                   
                });
            }
            return rdata;
        }

        public static List<AdminModel> Get()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminModel>())).Map<List<AdminModel>>(DataAccess.GetAdminDataAccess().Get());
            return data;
        }

        public static bool Create(InstitutionModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
