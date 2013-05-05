using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("grade", "Grade cannot be negative!");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("minGrade", "Minimal grade cannot be negative!");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("maxGrade", "Maximal grade should be smaller than or equal to the minimal grade!");
        }

        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentNullException("comments", "Comments are mandatory!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
