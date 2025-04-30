using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Question
    {
        public int ID { get; set; }
        public int Survey_ID { get; set; }
        public string Text { get; set; }
        public string Question_Type { get; set; }

    }
}
