using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_300_F22SD_Labs
{
    public class Enrolment
    {
        private int _enrolmentId;

        public int EnrolmentId
        {
            get { return _enrolmentId; }
        }

        public void SetEnrolmentId(int enrolmentId)
        {
            if (enrolmentId > 0)
            {
                _enrolmentId = enrolmentId;
            }
            else
            {
                throw new Exception("Enrollment Id must be a number higher than zero.");
            }
        } 

        public Course Course { get; set; }

        public Student Student { get; set; }

        private int _studentGrade;

        public int StudentGrade 
        {
            get { return _studentGrade; } 
        }

        public void SetStudentGrade(int studentGrade)
        {
            if (studentGrade >= 0 && studentGrade <= 100)
            {
                _studentGrade= studentGrade;
            }
            else
            {
                throw new Exception("Grade must be a number between 0 and 100");
            }
        }

        private DateTime? _enrolmentDate;

        public DateTime? EnrolmentDate
        {
            get { return _enrolmentDate; }

            set { _enrolmentDate = value; }
        }

        public Enrolment(int enrolmentId, Course course, Student student, int studentGrade)
        {
            _enrolmentId = enrolmentId;
            Course = course;
            Student = student;
            _studentGrade = studentGrade;
            EnrolmentDate = DateTime.Now;
            
        }

    }
}
