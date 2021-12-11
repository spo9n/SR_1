using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_Surgai_P81
{
    class Student
    {
        private string FullName;
        private int YearOfBirth;
        private int GroupNumber;
        private int[] Marks;
        private double AvgMark;

        public Student()
        {
            FullName = "Unknown";
            YearOfBirth = 0;
            GroupNumber = 0;
            Marks = null;
            AvgMark = 0;
        }

        public Student(string fullName, int yearOfBirth, int groupNum, int[] marks)
        {
            this.FullName = fullName;
            this.YearOfBirth = yearOfBirth;
            this.GroupNumber = groupNum;
            this.Marks = marks;

            foreach (int Mark in Marks)
            {
                AvgMark += Mark;
            }

            AvgMark /= Marks.Length;
        }

        public string setFullName()
        {
            return FullName;
        }

        public void setYearOfBith(int yearOfBirth)
        {
            this.YearOfBirth = yearOfBirth;
        }

        public void setGroupNum(int groupNumber)
        {
            this.GroupNumber = groupNumber;
        }

        public void setMarks(int[] marks)
        {
            this.Marks = marks;
        }

        public void setAverageMark(double avgMark)
        {
            this.AvgMark = avgMark;
        }

        public string getFullName()
        {
            return FullName;
        }

        public int getYearOfBith()
        {
            return YearOfBirth;
        }

        public int getGroupNum()
        {
            return GroupNumber;
        }

        public int[] getMarks()
        {
            return Marks;
        }

        public double getAverageMark()
        {
            return AvgMark;
        }
    }
}