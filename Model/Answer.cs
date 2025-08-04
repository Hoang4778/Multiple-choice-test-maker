using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model
{
    public class Answer
    {
        public int id { get; set; }
        public string content { get; set; }
        public int questionId { get; set; }
        public bool isCorrect { get; set; }
    }
}
