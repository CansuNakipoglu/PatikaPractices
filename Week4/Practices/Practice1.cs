using Week4.Practices.Abstracts;

namespace Week4.Practices;

/// <summary>
/// Sınıf Oluşturma
/// </summary>
public class Practice1:IPractice
{ 
    public void ExecPractice()
    {
        var student = new Person
        {
            Name = "Ali",
            Surname = "Yılmaz",
            BirthDate = new DateTime (2024, 8, 6)
        };
        
        var teacher = new Person
        {
            Name = "Tolunay",
            Surname = "Esergün",
            BirthDate = new DateTime (2020, 7, 12)
        };
        var student2 = new Person()
        {
            Name = "Ahmet",
            Surname = " Ay",
            BirthDate = new DateTime (2021, 6, 4)
        }; 
        
        Console.WriteLine(student.Name + " " + student.Surname + " " + student.BirthDate + student2.Name + " " + student2.Surname+ " " +student2.BirthDate+ " " + teacher.Name + " " + teacher.Surname + " " + teacher.BirthDate );
    }
}

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
}


    
