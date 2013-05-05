﻿using System;

public class SimpleMathExam : Exam
{
    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            throw new ArgumentOutOfRangeException("problemsSolved", "Solved problems cannot be negative!");
        }

        if (problemsSolved > 10)
        {
            throw new ArgumentOutOfRangeException("problemsSolved", "Solved problems cannot be larger than 10");
        }

        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved { get; private set; }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: One problem solved.");
        }
        else if (this.ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Good result: Two problem solved.");
        }

        throw new ArgumentOutOfRangeException("ProblemsSolved", "Invalid number of problems solved!");
    }
}
