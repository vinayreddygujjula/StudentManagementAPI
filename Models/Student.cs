using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        [Key]
        public int SId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student(int sId, string name, int age, double grade)
        {
            this.SId = sId;
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
    }
}
