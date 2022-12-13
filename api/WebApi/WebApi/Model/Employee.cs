using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    public class Employee
    {
        [Key]
        public int EMP_ID { get; set; }
        public string EMP_NAME { get; set; }
        public string EMP_DEPT { get; set; }
        public int EMP_REQ_ID { get; set; }
    }
}   
 