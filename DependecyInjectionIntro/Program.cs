using DependecyInjectionIntro;

var teacher = new Teacher
{
    FirstName = "Yusufcan",
    LastName = "Adıgüzel"
};

var classRoom = new ClassRoom(teacher);

classRoom.GetTeacherInfo();