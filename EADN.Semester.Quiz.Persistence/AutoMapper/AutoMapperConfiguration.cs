﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace EADN.Semester.Quiz.Persistence
{
    public static class AutoMapperConfiguration
    {
        public static MapperConfiguration Config { get; private set; }

        public static void Configure()
        {
            Config = new MapperConfiguration(cfg => cfg.CreateMap<Common.Contracts.Answer, Answer>());
        }
    }
}
