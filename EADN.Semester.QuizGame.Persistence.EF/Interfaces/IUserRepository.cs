﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EADN.Semester.QuizGame.Common;
using EADN.Semester.QuizGame.Persistence.EF.Models;

namespace EADN.Semester.QuizGame.Persistence.EF.Interfaces
{
    public interface IUserRepository : IRepository<User,Guid>
    {
    }
}
