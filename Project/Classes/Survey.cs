using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Survey
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// флаг активности опроса
        /// </summary>
        public bool Is_Active { get; set; }

    }
}
