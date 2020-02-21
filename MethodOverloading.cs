using System;
namespace OOPS
{
    public class student
    {
        protected student()
        {
            Console.WriteLine("Base class Contructor of student");
        }

        public string studentName
        {
            get
            {
                return this.studentName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("No empty or null values are accepted");
                }
            }

        }

        public int marks { get; set; }
        public int totalMarks(int first, int second)
        {
            return first + second;
        }
    }

    public class topper : student
    {
        public topper()
        {
            Console.WriteLine("Full time constructor invoked");
        }
        public string topperName
        {
            get { return this.topperName; }
            set
            {
                if (string.IsNullOrEmpty(value))

                {
                    throw new Exception("No null values are accepted of topper name");
                }
            }
        }

        public int marksTopper { get; set; }

        public new int totalMarks(int first, int second)
        {
            return first + second;
        }

        /*public void totalMarks(int first ,int second){   it is npt possible to overload the method only with return type because it is not the method signature
        //     Console.WriteLine( first + second);
        // } */
        public int totalMarks(int first, int second, int third)
        {
            return first + second + third;
        }
    }
}