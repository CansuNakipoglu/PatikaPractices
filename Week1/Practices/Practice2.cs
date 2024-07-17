using Week1.Practices.Abscracts;

namespace Week1.Practices;

/// <summary>
/// Değişken Tanımlama Ve Atama İşlemleri
/// </summary>
public class Practice2: IPractice
{
    public void ExecPractice()
    {
        // Değişken Tanımlama
        int number;
        string name;
        bool isSuccess;
        double percentNumber;
        char key;
        
        // Değişken Atama
        number = 5;
        name = "Cansu";
        isSuccess = true;
        percentNumber = 0.2;
        key = 'C';
        
        Console.WriteLine($"number = {number}, name = {name}, isSuccess = {isSuccess}, percentNumber = {percentNumber}, key = {key} ");
        
        // Değişken Tanımlarken Atama
        int newNumber = 2;
        string newName = "Tolunay";
        bool isFail = false;
        double newPercent = 0.5;
        char newKey = 'T';


    }
}