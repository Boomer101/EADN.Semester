﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADN.Semester.Quiz.Persistence
{
    public class Quiz : QuizItem
    {
        public HashSet<Topic> Topics { get; set; }
        public Question Question { get; set; }
        public List<Answer> Answers { get; set; }

        public Quiz()
        {
            Topics = new HashSet<Topic>();
            Answers = new List<Answer>();
        }
    }
}
