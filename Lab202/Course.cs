using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        string name;
        string courseID;
        string lecturer;
        int maxStudents;
        int numStudents;


        public Course(){
        this.name=" ";
        this.courseID=" ";
        this.lecturer="staff";
        this .maxStudents=30;
        this .numStudents=0;
        }
        public Course(string n, string coid)
        {
            this.name = n;
            this.courseID = coid;
            this.lecturer = " Staff";
            this.maxStudents = 30;
            this.numStudents = 0;
        }
        public Course(string n, string coid, string lecture)
        {
            this.name =n;
            this.courseID = coid;
            this.lecturer = lecture;
            this.maxStudents = 30;
            this.numStudents = 0;
        }
        public Course(string n, string coid, string lecture, int maxstu)
        {
            this.name = n;
            this.courseID = coid;
            this.lecturer = lecture;
            this.maxStudents = maxstu;
            this.numStudents =0;
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public string Lecturer {
            get {
                return lecturer;
            }
            set {
                lecturer = value;
            }
        }
        public string CourseID {
            get {
                return courseID;
            }
            set {
                    if (value.Length != 6)
                    {
                        Console.WriteLine(courseID+": error try setting invalid CourseID!");
                    }
                    else {
                        int b = 0;
                        for (int a = 0; a < value.Length; a++)
                        {
                            if (char.IsDigit(value[a]))
                            {
                                b++;
                            }
                            
                        }
                        if (b == 6)
                        {
                            courseID = value;
                        }
                        else {
                            Console.WriteLine(courseID + ": error try setting invalid CourseID!");
                        }
                    }
                }
        }

        public int MaxStudents { 
            get {
                return maxStudents;
            }
            set {
                if (value <= 80 && value >= 0 && value >= numStudents)
                {
                    maxStudents = value;
                }
                else {
                    Console.WriteLine(courseID+ ": error try setting invalid Max No. Students!");
                }
            }
        }

        public int NumStudents {
          
            get {
                return numStudents;
            }
            set {
                if (value >= 0 && value <= maxStudents)
                {
                    numStudents = value;
                }
                else {
                    Console.WriteLine( courseID+" : error try setting invalid No. Students!");
                }
                
            }
        }
        public override String ToString()
        {
            return "[Course: " + name+"("+courseID + ")," + "Lecture=" + lecturer + ", has " + numStudents + " students, " + " max=" + maxStudents + "]";
            
        }
    }
}
