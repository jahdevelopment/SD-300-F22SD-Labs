using SD_300_F22SD_Labs;

HashSet<Enrolment> enrolments = new HashSet<Enrolment>();

void AddEnrolment(Enrolment enrolment)
{
    if (!enrolments.Contains(enrolment))
    {
        enrolments.Add(enrolment);

        enrolment.Course.AddStudentToCourse(enrolment.Student);

        enrolment.Student.Course = enrolment.Course;

        enrolment.EnrolmentDate = DateTime.Now;

        Console.WriteLine("Enrolment succesfull");
    }
    else
    {
        throw new Exception($"Student with Id {enrolment.Student.StudentId} already registered in enrolment database.");
    }
}

void DeleteEnrolment(Enrolment enrolment)
{
    if (enrolments.Contains(enrolment))
    {
        enrolment.Course.RemoveStudentFromCourse(enrolment.Student);

        enrolment.Course = null;

        enrolment.Student = null;

        enrolment.EnrolmentDate = null;

        Console.WriteLine("Enrolment deleted");
    }
    else
    {
        throw new Exception($"Student with Id {enrolment.Student.StudentId} does't exist in enrolment database.");
    }
}



try
{
    Course software = new Course(200, "Software Developer", 30);

    Student Daniel = new Student(1000, "Daniel", "Perez");
    Student Carlos = new Student(1001, "Carlos", "Díaz");

    Enrolment enrolOne = new Enrolment(1, software, Daniel, 0);
    Enrolment enrolTwo = new Enrolment(2, software, Carlos, 0);

    enrolOne._setStudentGrade(85);
    enrolTwo._setStudentGrade(79);

    AddEnrolment(enrolOne);
    AddEnrolment(enrolTwo);

    Console.WriteLine($"1. {enrolOne.EnrolmentDate}");
    Console.WriteLine($"2. {enrolOne.Course.Title}");
    Console.WriteLine($"3. {enrolOne.Student.LastName}");
    Console.WriteLine($"4. {enrolTwo.StudentGrade}");
    Console.WriteLine($"5. {enrolTwo.Student.StudentId}");
    Console.WriteLine($"6. {enrolments.Count}");
    
    //AddEnrolment(enrolTwo);
    
    Console.WriteLine($"7. {Daniel.Course.CourseId}");
    
    DeleteEnrolment(enrolTwo);
    
    Console.WriteLine($"8. {enrolOne.Course.GetStudentInCourse(1001)}");
    Console.WriteLine($"9. {enrolments.Count}");
    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
    
    
    
    
    
    



//---------------------------------------------------------------------------------------------------------------------//





//void EnrolStudent(Course course, Student student)
//{
//    if (Course.GetStudentInCourse(student.StudentId) == null)
//    {
//        course.AddEnrolmentToCourse(enrolment);

//    }
//}

//void RegisterStudent(Student student, Course course)
//{

//    if (course.GetStudentInCourse(student.StudentId) == null)
//    {

//        course.AddStudentToCourse(student);

//        student.Course = course;

//        student.RegistrationDate = DateTime.Now;
//    }
//    else
//    {
//        throw new Exception($"Student with id {student.StudentId} already registered in Course {course.Title}");
//    }
//}


//void DeregisterStudent(Student student, Course course)
//{
//    if (student.Course.CourseId == course.CourseId && course.GetStudentInCourse(student.StudentId) == student)
//    {
//        course.RemoveStudentFromCourse(student);

//        student.Course = null;

//        student.RemoveGrade();

//        student.RegistrationDate = null;
//    }
//    else
//    {
//        throw new Exception($"The student with Id {student.StudentId} doesn't belong to the course {course.Title}");
//    }
//}