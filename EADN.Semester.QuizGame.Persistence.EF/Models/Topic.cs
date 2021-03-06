﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADN.Semester.QuizGame.Persistence.EF
{
    public class Topic : QuizBase
    {
        [Required]
        [MaxLength(255)]
        [Index("TopicTextIndex", IsUnique = true)]
        public string Text { get; set; }

        public ICollection<Question> Questions { get; set; }

        public Topic()
        {
            Questions = new HashSet<Question>();
        }
    }
}
