using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model
{
    internal class Student
    {
        public int id {  get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public decimal? averageGrade { get; set; }
    }
}
