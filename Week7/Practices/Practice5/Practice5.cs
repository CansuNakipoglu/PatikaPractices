using Week7.Practices.Abstracts;

namespace Week7.Practices
{
    public class Practice5 : IPractice
    {
        public void ExecPractice()
        {
            // Öğrenciler listesi
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
                new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
                new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
                new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
                new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 }
            };

            // Sınıflar listesi
            List<Class> classes = new List<Class>
            {
                new Class { ClassId = 1, ClassName = "Matematik" },
                new Class { ClassId = 2, ClassName = "Türkçe" },
                new Class { ClassId = 3, ClassName = "Kimya" }
            };

            // LINQ group join sorgusu ile sınıfları ve o sınıfa ait öğrencileri birleştiriyoruz
            var query = from classItem in classes
                        join student in students on classItem.ClassId equals student.ClassId into studentGroup
                        select new
                        {
                            ClassName = classItem.ClassName,
                            Students = studentGroup.Select(s => s.StudentName).ToList()
                        };

            // Sonuçları uygun formatta ekrana yazdırıyoruz
            foreach (var classGroup in query)
            {
                Console.WriteLine($"Sınıf: {classGroup.ClassName}");
                Console.WriteLine("Öğrenciler:");
                foreach (var student in classGroup.Students)
                {
                    Console.WriteLine($"- {student}");
                }
                Console.WriteLine();  // Sınıflar arasında boşluk bırakmak için
            }
        }
    }

    // Öğrenci sınıfı (Students tablosunu temsil ediyor)
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }  // Öğrencinin sınıfıyla ilişkili kimlik
    }

    // Sınıf sınıfı (Classes tablosunu temsil ediyor)
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }  // Sınıfın adı
    }
}