﻿namespace Homework6;
// ---Q1---
class Professor{
    public string? profName; 
    public string? classTeach;
    private double salary;
public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
public double GetSalary(){
        return salary;

    }
}
class Student{
    public string? studentName;
    public string? classEnroll;
    private double studentGrade;
public void SetStudentGrade(double newGrade){
        studentGrade = newGrade;
    }
public double GetStudentGrade(){
        return studentGrade;
    }
}
class Program
{
static void Main(string[] args)
    {
        //objects of Professor class
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        
        //objects for Student class 
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetStudentGrade(90);
        
        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetStudentGrade(80);
    //---Q2---
        Console.WriteLine("Professor " + p1.profName + " teaches " + p1.classTeach + ", and the salary is: " + p1.GetSalary());
        Console.WriteLine("Professor " + p2.profName + " teaches " + p2.classTeach + ", and the salary is: " + p2.GetSalary());

        Console.WriteLine("Student " + s1.studentName + " enrolls " + s1.classEnroll + ", and the grade is: " + s1.GetStudentGrade());
        Console.WriteLine("Student " + s2.studentName + " enrolls " + s2.classEnroll + ", and the grade is: " + s2.GetStudentGrade());

        Console.WriteLine("The salary difference between " + p1.profName + " and " + p2.profName + " is: " + (p1.GetSalary() - p2.GetSalary()));
        Console.WriteLine("The total grade of " + s1.studentName + " and " + s2.studentName + " is: " + (s1.GetStudentGrade() + s2.GetStudentGrade()));
        

    }
}