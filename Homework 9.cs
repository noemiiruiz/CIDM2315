using System;

    // Q1
class Student
{
        private int studentID;
        private string studentName; 
        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
        public int GetStudentID()
        {
        return studentID;
        }
        public string GetStudentName()
        {
        return studentName;
        }
        public static List<Student> student_list = new List<Student>();
        public Student(int inputID, string inputName)
        {
            this.studentID = inputID;
            this.studentName = inputName;
            student_list.Add(this);
        }
    // Q2
public class Program
{
    public static void Main(string[] args)
    {
        Student a = new Student(111, "Alice");
        Student b = new Student(222, "Bob");
        Student c = new Student(333, "Cathy");
        Student d = new Student(444, "David");
    // Q3
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);   
    // Q4
        foreach(var stu in gradebook){
        }
        if(!gradebook.ContainsKey("Tom"))
        {
        gradebook.Add("Tom",3.3);
        }
    // Q5
        double total = 0;
        foreach(KeyValuePair<string,double> entry in gradebook)
        {
            total += entry.Value;
        }
        double average = total / gradebook.Count;
        Console.WriteLine($"The Average GPA: {average}");
    // Q6
        foreach(KeyValuePair<string, double> entry in gradebook)
        {
        if(entry.Value > average)
        {
            foreach(Student student in Student.student_list)
            {
                if(student.GetStudentName() == entry.Key)
                {
                    student.PrintInfo();
                }
            }
        }
        }
    }
}
}