using System;

namespace Multiple_Choice_Tests
{
    //Link to the challenge https://edabit.com/challenge/thXMEAWNWyk9cCZcM
    class Program
    {
        static void Main(string[] args)
        {
            ITestpaper paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            ITestpaper paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
            ITestpaper paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

            IStudent student1 = new Student();
            IStudent student2 = new Student();

            foreach(string test in student1.TestsTaken)
            {
                Console.WriteLine(test);
            }

            student1.TakeTest(paper1, new string[] { "1A", "2C", "3B", "4C", "5A" });
            student1.TakeTest(paper2, new string[] { "1C", "2C", "3D", "4B" });
            Console.WriteLine("Student1");

            foreach (string test in student1.TestsTaken)
            {
                Console.WriteLine(test);
            }



            Console.WriteLine("\n\nStuden2\n");

            student2.TakeTest(paper1, new string[] { "1A", "2C", "3B", "4C", "5A" });
            student2.TakeTest(paper2, new string[] { "1C", "2C", "3D", "4B" });
            student2.TakeTest(paper3, new string[] { "1D", "2A", "3B", "4D", "5A", "6B", "7C" });

            foreach (string test in student2.TestsTaken)
            {
                Console.WriteLine(test);
            }
        }
    }
}
