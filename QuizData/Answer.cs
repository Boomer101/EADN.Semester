﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizData
{
    public class Answer : QuizGameElement
    {
        bool IsCorrect { get; set; }
        bool ChosenByUser { get; set; }
    }
}