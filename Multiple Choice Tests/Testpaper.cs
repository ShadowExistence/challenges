using System;
using System.Collections.Generic;
using System.Text;

namespace Multiple_Choice_Tests
{
    public interface ITestpaper
    {
        string Subject { get; set; }
        string[] MarkScheme { get; set; }
        string PassMark { get; set; }
    }

    public class Testpaper : ITestpaper
    {
        public string Subject { get; set; }
        public string[] MarkScheme { get; set; }
        public string PassMark { get; set; }

        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            PassMark = passMark;
            MarkScheme = markScheme;
            Subject = subject;
        }
        
    }
}
