﻿using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class CourseRepo : IRepo<Cours, int>
    {
        Education_Platform_Final_TermEntities db;
        public CourseRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public bool Create(Cours obj)
        {
            db.Courses.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var course = db.Courses.FirstOrDefault(e => e.Id == id);
            db.Courses.Remove(course);
            db.SaveChanges();
            return true;
        }

        public List<Cours> Get()
        {
            return db.Courses.ToList();

        }

        public Cours GetId(int id)
        {
            var course = (from i in db.Courses
                               where i.Id == id
                               select i).FirstOrDefault();
            return course;
        }

        public bool Update(Cours obj)
        {
            var course = (from i in db.Courses where i.Id == obj.Id select i).FirstOrDefault();
            db.Entry(course).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }
}
       
      
