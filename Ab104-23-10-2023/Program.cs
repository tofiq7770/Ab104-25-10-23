using Ab104_23_10_2023;

class Program
{
    static void Main()
    {
        //    List<Person> people = new List<Person>
        //    {
        //        new Person { Name = "Kamil", Surname = "Zeynalli", Age = 33 },
        //        new Person { Name = "Ali", Surname = "Huseynov", Age = 19 },
        //        new Person { Name = "Ali", Surname = "Shukurlu", Age = 18 },
        //        new Person { Name = "Ali", Surname = "Aliyev", Age = 21 },
        //    };

        ////task1.1

        //Console.WriteLine("Axtarilan adi daxil edin:");
        //string name =Console.ReadLine().ToLower();
        //var nameIs = people.FindAll(p => p.Name.ToLower() == name);
        //foreach (Person person in nameIs)
        //{
        //    Console.WriteLine($"{name.ToUpper().Substring(0, 1) + name.ToLower().Substring(1, name.Length - 1)} ile bagli melumatlar");
        //    Console.WriteLine($"{person.Name} {person.Surname} - Yas : {person.Age}");
        //}

        ////task1.2

        ////var surnameEndWith = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova") || p.Surname.EndsWith("yev") || p.Surname.EndsWith("yeva"));
        ////Console.WriteLine("Soyadı ov, ova, yev, yeva ile biten Shexsler:");
        ////foreach (Person person in surnameEndWith)
        ////{
        ////    Console.WriteLine($"{person.Name} {person.Surname} - Yas : {person.Age}");
        ////}

        ////task1.3

        //////var findAge20 = people.FindAll(p => p.Age >= 20);
        //////Console.WriteLine("Yası 20+ olan Shexsler:");
        //////foreach (var person in findAge20)
        //////{
        //////    Console.WriteLine($"{person.Name} {person.Surname} - Yas : {person.Age}");
        //////}



        //task2


        //List<Exam> exams = new List<Exam>();

        //exams.Add(new Exam
        //{
        //    Subject = "Code",
        //    ExamDuration = 5,
        //    StartDate = DateTime.FromOADate(7),
        //    EndDate = DateTime.FromOADate(9)
        //});

        //exams.Add(new Exam
        //{
        //    Subject = "English",
        //    ExamDuration = 4,
        //});

        //exams.Add(new Exam
        //{
        //    Subject = "Math",
        //    ExamDuration = 1,
        //    StartDate = DateTime.Now.AddDays(-9),
        //    EndDate = DateTime.Now.AddDays(10),
        //});
        //exams.Add(new Exam
        //{
        //    Subject = "IQ",
        //    ExamDuration = 2,
        //    StartDate = DateTime.FromOADate(1),
        //    EndDate = DateTime.FromOADate(14)
        //});

        //exams.Add(new Exam
        //{
        //    Subject = "Philosophy",
        //    ExamDuration = 0.5,
        //});

        //exams.Add(new Exam
        //{
        //    Subject = "Chemistry",
        //    ExamDuration = 3,
        //});

        //task2.1

        //var recentExams = exams.Where(e => e.EndDate >= DateTime.Now.AddDays(-7)).ToList();
        //Console.WriteLine("Son 1 hefte erzinde olan  examlarin siyahisi: ");
        //PrintExamList(recentExams);

        //task2.2

        ////var longTimeExams = exams.Where(e => e.ExamDuration > 2).ToList();
        ////Console.WriteLine("2 saatdan uzun ceken imtahanlarin siyahisi: ");
        ////PrintExamList(longTimeExams);


        //////task2.3

        //////var examOnGoing = exams.Where(e => e.StartDate <= DateTime.Now && e.EndDate > DateTime.Now).ToList();
        //////Console.WriteLine("Bashlayib amma bitmemish(hal-hazirda devam eden) imtahanlarin siyahisi: ");
        //////PrintExamList(examOnGoing);
    }

    //static void PrintExamList(List<Exam> examList)
    //{
    //    foreach (Exam exam in examList)
    //    {
    //        Console.WriteLine($"Fenn: {exam.Subject}, Saat: {exam.ExamDuration} ");
    //    }
    //}

}
