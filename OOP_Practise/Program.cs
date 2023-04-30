using OOP_Practise.Task_1;



//N1.A

Student student = new Student("Ekaterine", "Tchonishvili", "01010101010",
    new List<Subject>
    {
    new Subject("Advanced math", new List<string> { "Math", "calculus" }, 5, 20),
    new Subject("Advanced math", new List<string> { "Math1", "calculus1" }, 7, 10)
});

var semester = new Semester(1, new List<Subject>
{
    new Subject("Advanced Math", new List<string> { "Math", "Calculus" }, 5, 20),
    new Subject("Computer Science", new List<string> { "Programming", "Data Structures" }, 7, 15)
});

student.AddSemester(semester);
Console.WriteLine(student.SemesterInfo());


//N1.B
//Exception Example - Teacher with Four Subjects
//Teacher teacher = new Teacher("Ekaterine", "Tchonishvili", new List<Subject> {
//    new Subject("Advanced math", new List<string> { "Math", "calculus" }, 5, 20),
//    new Subject("Advanced math", new List<string> { "Math1", "calculus1" }, 7, 10),
//    new Subject("Advanced math", new List<string> { "Math1", "calculus1" }, 7, 10),
//    new Subject("Advanced math", new List<string> { "Math1", "calculus1" }, 7, 10)
//});

//Exception Example - Teacher with Three Subjects
//Teacher teacher = new Teacher("Ekaterine", "Tchonishvili", new List<Subject> {
//    new Subject("Advanced math", new List<string> { "Math", "calculus" }, 5, 20),
//    new Subject("Advanced math", new List<string> { "Math1", "calculus1" }, 7, 10),
//    new Subject("Advanced math", new List<string> { "Math1", "calculus1" }, 7, 10)
//});

//Add Subject
//Teacher teacher = new Teacher("Ekaterine", "Tchonishvili", new List<Subject> {
//    new Subject("Advanced math", new List<string> { "Math", "calculus" }, 5, 20),
//    new Subject("Advanced math", new List<string> { "Math1", "calculus1" }, 7, 10)
//});

//teacher.AddSubject(new Subject("Advanced physics", new List<string> { "Cosmology", "Field Theory" }, 7, 10));

//Console.WriteLine(teacher);


//N1.C 
//Subject subj = new Subject("Advanced math", new List<string> { "Math", "calculus" }, 5, 20);
//Console.WriteLine(subj);


//N2
//CustomQueue<int> customqueue = new CustomQueue<int>();
//customqueue.AddItem(4);
//customqueue.AddItem(1);
//customqueue.AddItem(5);
//customqueue.AddItem(6);
//Console.WriteLine(customqueue.Count());
//customqueue.DeleteItem();
//Console.Write("\n");
//customqueue.PrintItems();


//N3
//Rectangle r1 = new Rectangle(length: 5, width: 15);
//double area = r1.calculateArea();
//Console.WriteLine(area);


//Triangle r2 = new Triangle(3, 4, 5);
//double area2 = r2.calculateArea();
//Console.WriteLine(area2);

