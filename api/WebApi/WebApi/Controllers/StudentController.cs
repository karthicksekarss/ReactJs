using Microsoft.AspNetCore.Mvc;
using System.Data.Entity.Migrations;
using WebApi.DataBase;
using WebApi.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private SchoolContext db = new SchoolContext();

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var students = db.Students.ToList();
            return students;
        }

        [HttpGet]
        [Route("id")]
        public Student Get(int id)
        {
            return db.Students.FirstOrDefault(x => x.id == id);
        }

        [HttpPost]
        [Route("Create")]
        public Student Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return student;
        }

        [HttpPut]
        [Route("Update")]
        public Student Update(Student student)
        {
            db.Students.AddOrUpdate(student);
            db.SaveChanges();
            return student;
        }

        [HttpDelete]
        [Route("Delete")]
        public bool Delete(int id)
        {
            var datatodelete = db.Students.FirstOrDefault(x => x.id == id);
            if (datatodelete != null)
            {
                db.Students.Remove(datatodelete);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
