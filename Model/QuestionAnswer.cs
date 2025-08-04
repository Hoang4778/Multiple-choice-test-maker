using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model
{
    public class QuestionAnswer
    {
        public int id {  get; set; }
        public string content { get; set; }
        public List<Answer> answers { get; set; }
    }
}
