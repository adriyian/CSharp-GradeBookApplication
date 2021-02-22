using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (averageGrade < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }
            else if (averageGrade <= 20)
            {
                return 'A';
            }
            else if (averageGrade <= 40)
            {
                return 'B';
            }
            else if (averageGrade <= 60)
            {
                return 'C';
            }
            else if (averageGrade <= 80)
            {
                return 'D';
            }

            return 'F';
        }
    }
}