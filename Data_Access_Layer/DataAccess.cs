using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DataAccess
    {
        static Education_Platform_Final_TermEntities db = new Education_Platform_Final_TermEntities();

        public static IRepo<Admin, int> GetAdminDataAccess()
        {
            
            return new AdminRepo(db);

        }
        public static IRepo<Institution, int> GetInstitutionDataAccess()
        {
            return new InstitutionRepo(db);
        }
        public static IRepo<Mentor, int> GetMentorDataAccess()
        {
            return new MentorRepo(db);
        }
        public static IRepo<Notice, int> GetNoticeDataAccess()
        {
            return new NoticeRepo(db);
        }
        public static IRepo<Cours, int> GetCourseDataAccess()
        {
            return new CourseRepo(db);
        }
        public static IRepo<Result, int> GetResultDataAccess()
        {
            return new ResultRepo(db);
        }

        public static IRepo<Transaction, int> GetTransactionDataAccess()
        {
            return new TransactionRepo(db);
        }
        public static IInstitutionAuth GetInstitutionTokenDataAccess()
        {
            return new InstitutionTokenRepo(db);
        }
    }
}
