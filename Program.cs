using SD_300_F22SD_Labs;

Course Software = new Course(200, "Software Developer", 30);
Student Jimmy = new Student(1000, "Jimmy", "Smith");


try
{
    RegisterStudent(Jimmy, Software);

    Console.WriteLine(Jimmy.RegistrationDate);

    DeregisterStudent(Jimmy, Software);

    Console.WriteLine(Jimmy.RegistrationDate);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}



void RegisterStudent(Student student, Course course)
{

    if (course.GetStudentInCourse(student.StudentId) == null)
    {

        course.AddStudentToCourse(student);

        student.Course = course;

        student.RegistrationDate = DateTime.Now;
    }
    else
    {
        throw new Exception($"Student with id {student.StudentId} already registered in Course {course.Title}");
    }
}


void DeregisterStudent(Student student, Course course)
{
    if (student.Course.CourseId == course.CourseId && course.GetStudentInCourse(student.StudentId) == student)
    {
        course.RemoveStudentFromCourse(student);

        student.Course = null;

        student.RemoveGrade();

        student.RegistrationDate = null;
    }
    else
    {
        throw new Exception($"The student with Id {student.StudentId} doesn't belong to the course {course.Title}");
    }
}