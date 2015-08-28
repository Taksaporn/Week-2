using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        string name;
        string studentID;
        int yearOfBirth;
        bool iSActive;

        public Student() {
           this.name = "John Doe";
           this.studentID = "Unknown";
           this.yearOfBirth = 1995;
           this.iSActive = false;
        }

        public Student(string n, string stuID){
            this.name=n;
            this.studentID=stuID;
            this.yearOfBirth = 1995;
            this.iSActive = true;
        }

        public Student(string n, string stuID, int YOfB) {
            this.name=n;
            this.studentID=stuID;
            this.yearOfBirth=YOfB;
            this.iSActive = true;
        }

        public Student(string n, string stuID, int YOfB,bool isactive)
        {
            this.name=n;
            this.studentID=stuID;
            this.yearOfBirth=YOfB;
            this.isActive = true;
        }

        public string Name {
            get{
                return name;
            }
            set {
                name=value;
            }
        }

        public string StudentID {
            get {
                return studentID;
            }
            set {
                studentID = value;
            }
        }

        public int YearOfBirth {
            get {
                return yearOfBirth;
            }
            set {

                if (value >= 1950 && value <= 2000)
                {
                    yearOfBirth = value;

                }
                else
                {
                    Console.WriteLine("{0} error try setting invalid year-of-birth value!", StudentID);
                }

            }
        }

        public bool isActive {
            get {
                return true;
            }
            set {
                iSActive = value;
            }
        }
        public int getAge() {
            return DateTime.Now.Year - yearOfBirth;
        }

        public override string ToString() {
            if (iSActive == true)
            {
                return "[Student: " + name + " (" + studentID + "), age=" + getAge() + ", is active student]";
            }
            else {
                return "[Student: " + name + " (" + studentID + "), age=" + getAge() + ", is NOT active student]";
            }
        }
        

    }
}
