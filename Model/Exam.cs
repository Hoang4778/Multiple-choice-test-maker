using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model
{
    public class Exam
    {
        public int id {  get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime examDate { get; set; }
        public TimeSpan startTime { get; set; }
        public decimal duration { get; set; }
        public int questionAmount { get; set; }
        public int maxScore { get; set; }
        public int classId { get; set; }
    }
}
