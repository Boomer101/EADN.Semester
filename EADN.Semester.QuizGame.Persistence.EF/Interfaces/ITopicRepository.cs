﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EADN.Semester.QuizGame.Common;

namespace EADN.Semester.QuizGame.Persistence.EF.Interfaces
{
    public interface ITopicRepository<Topic,Guid> : IRepository<Topic, Guid>
    {
        IEnumerable<Topic> GetAllTopics();
    }
}