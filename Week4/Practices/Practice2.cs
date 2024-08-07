using Week4.Practices.Abstracts;

namespace Week4.Practices;
/// <summary>
/// Constructor Method
/// </summary>

public class Practice2:IPractice
{
    public void ExecPractice()
    {
        Bebek naz = new Bebek("Naz", "Nakipoğlu");
        Console.WriteLine(naz.Name + " " + naz.Surname + " " + naz.BirthDate);
        
        Bebek poyraz = new Bebek();
        poyraz.Name = "poyraz";
        poyraz.Surname = "Nakipoğlu";
        Console.WriteLine(poyraz.Name + " " + poyraz.Surname + " " + poyraz.BirthDate);
    }
}

public class Bebek
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }

    public Bebek()
    {
        BirthDate = DateTime.Now;
        Console.WriteLine("Ingaaaa");
        
    }
    public Bebek(string name, string surname)
    {
        Name = name;
        Surname = surname;
        BirthDate = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

}