using System.ComponentModel.DataAnnotations;

namespace WebServices.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
