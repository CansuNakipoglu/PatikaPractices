using Week4.Practices.Abstracts;

namespace Week4.Practices;
/// <summary>
/// Constructor Method
/// </summary>

public class Practice2:IPractice
{
    public void ExecPractice()
    {
        Baby naz = new Baby("Naz", "Nakipoğlu");
        Console.WriteLine(naz.Name + " " + naz.Surname + " " + naz.BirthDate);
        
        Baby poyraz = new Baby();
        poyraz.Name = "poyraz";
        poyraz.Surname = "Nakipoğlu";
        Console.WriteLine(poyraz.Name + " " + poyraz.Surname + " " + poyraz.BirthDate);
    }
}

public class Baby
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }

    public Baby()
    {
        BirthDate = DateTime.Now;
        Console.WriteLine("Ingaaaa");
        
    }
    public Baby(string name, string surname)
    {
        Name = name;
        Surname = surname;
        BirthDate = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

}