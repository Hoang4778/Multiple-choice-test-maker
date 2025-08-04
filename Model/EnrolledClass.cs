using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model
{
    internal class EnrolledClass
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public decimal? finalGrade { get; set; }
        public int classId { get; set; }
    }
}
