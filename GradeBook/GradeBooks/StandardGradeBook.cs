﻿using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Standard;
        }

        public override void CalculateStatistics()
        {
            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            base.CalculateStudentStatistics(name);
        }

        public override double GetGPA(char letterGrade, StudentType studentType)
        {
            return base.GetGPA(letterGrade, studentType);
        }

        public override char GetLetterGrade(double averageGrade)
        {
            return base.GetLetterGrade(averageGrade);
        }
    }
}
