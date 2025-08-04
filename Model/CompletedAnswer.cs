using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model
{
    internal class CompletedAnswer
    {
        public int id {  get; set; }
        public int contestantId { get; set; }
        public int examId { get; set; }
        public int questionId { get; set; }
        public int? answerId { get; set; }
    }
}
