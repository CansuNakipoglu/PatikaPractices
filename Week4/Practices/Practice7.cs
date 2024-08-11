using Week4.Practices.Abstracts;
namespace Week4.Practices;

/// <summary>
/// Abstraction Pratiği
/// </summary>
public class Practice7:IPractice
{
    public void ExecPractice()
    {
        var employees = new List<Employee>();
        
        Employee developer = new Developer();
        developer.Name = "Cansu";
        developer.Surname = "Nakipoğlu";
        developer.Department = "Depo";
        employees.Add(developer);
        
        Employee productOwner = new ProductOwner();
        productOwner.Name = "Irmak";
        productOwner.Surname = "Nakipoğlu";
        productOwner.Department = "Depo";
        employees.Add(productOwner);

        foreach (var employee in employees)
        {
            employee.WritePositionInformation();
        }
    }
}

public abstract class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Department { get; set; }

    public abstract void WritePositionInformation();

}

public class Developer : Employee
{
    public string TechStack { get; set; }
    public override void WritePositionInformation()
    {
        Console.WriteLine($"{Name} {Surname} {Department} departmanında yazılımcı olarak çalışmaktadır. ");
    }
}

public class ProductOwner : Employee
{
    public string Domain { get; set; }
    public override void WritePositionInformation()
    {
        Console.WriteLine($"{Name} {Surname} {Department} departmanında product owner olarak çalışmaktadır. ");
    }
}


