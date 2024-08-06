using Week4.Practices.Abstracts;

namespace Week4.Practices;

/// <summary>
/// Sınıf Oluşturma
/// </summary>
public class Practice1:IPractice
{ 
    public void ExecPractice()
    {
        List<Person> persons = new List<Person>();
        
        var student = new Person
        {
            Name = "Ali",
            Surname = "Yılmaz",
            BirthDate = new DateTime (2024, 8, 6)
        };
        persons.Add(student);
        
        var teacher = new Person
        {
            Name = "Lodos",
            Surname = "Eser",
            BirthDate = new DateTime (2020, 7, 12)
        };
        persons.Add(teacher);
        
        var student2 = new Person()
        {
            Name = "Ahmet",
            Surname = "Ay",
            BirthDate = new DateTime (2021, 6, 4)
        };
        persons.Add(student2);

        foreach (var person in persons)
        {
            person.WriteIdentity();
        }
    }
}

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }

    public void WriteIdentity()
    {
        Console.WriteLine(Name + " " + Surname + " " + BirthDate);
    }
}


    
