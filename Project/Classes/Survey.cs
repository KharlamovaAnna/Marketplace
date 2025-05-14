using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Survey
    {
        /// <summary>
        /// айдишечка
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// название 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// флаг активности опроса
        /// </summary>
        public bool Is_Active { get; set; }

    }
}
