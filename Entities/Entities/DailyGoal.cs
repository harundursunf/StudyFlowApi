﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class DailyGoal
    {


        public int Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public User User { get; set; }

        
    }
}
