﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Lesson11._2.Entities
{
    public class Group
    {
        public Group()
        {
            Students = new List<Student>();
        }

        public int GroupId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
