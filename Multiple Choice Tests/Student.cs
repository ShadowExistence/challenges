using System;
using System.Collections.Generic;
using System.Text;

namespace Multiple_Choice_Tests
{
    public interface IStudent
    {
        string[] TestsTaken { get; set; }
        void TakeTest(ITestpaper paper, string[] answers);
    }


    class Student : IStudent
    {
        int testsTaken = 0;
        public string[] TestsTaken { get; set; } = { "No tests taken" };

        
        public void TakeTest(ITestpaper paper, string[] answers)
        {
            double goodAnswers = 0;
            

            for (int i = 0; i < paper.MarkScheme.Length; i++)
            {
                if (paper.MarkScheme[i] == answers[i])
                {
                    goodAnswers += 1;
                }
            }
            double percent = Math.Round(goodAnswers / paper.MarkScheme.Length * 100);

            if (percent >= Convert.ToInt32((paper.PassMark.Remove(2))))
            {
                if (testsTaken == 0)
                {
                   TestsTaken[0] = $"{paper.Subject}: Passed! ({percent}%)";
                }
                else
                {
                    string[] newOutput = new string[testsTaken+1];
                    for (int i = 0; i < TestsTaken.Length; i++)
                    {
                        newOutput[i] = TestsTaken[i];
                    }
                    newOutput[testsTaken] = $"{paper.Subject}: Passed! ({percent}%)";
                    TestsTaken = newOutput;
                }
            }
            else
            {
                if (testsTaken == 0)
                {
                    TestsTaken[0] = $"{paper.Subject}: Failed! ({percent}%)";
                }
                else
                {
                    string[] newOutput = new string[testsTaken + 1];
                    for (int i = 0; i < TestsTaken.Length; i++)
                    {
                        newOutput[i] = TestsTaken[i];
                    }
                    newOutput[testsTaken] = $"{paper.Subject}: Failed! ({percent}%)";
                    TestsTaken = newOutput;
                }
            }

            testsTaken++;
        }
    }
}
