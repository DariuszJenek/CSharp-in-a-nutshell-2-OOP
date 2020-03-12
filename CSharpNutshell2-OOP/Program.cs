using System;
using System.Threading.Channels;

namespace CSharpNutshell2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int answer1 = random.Next(0, 2);
            int answer2 = random.Next(0, 2);
            int answer3 = random.Next(0, 2);
            int answer4 = random.Next(0, 2);
            int answer5 = random.Next(0, 2);

            int sum = 0;
            sum += answer1;
            sum += answer2;
            sum += answer3;
            sum += answer4;
            sum += answer5;

            Console.WriteLine($"{sum} na 5 punktow. Wynik: {sum/5.0}");

            var answers_tab = new int[30];
            int sum_tab = 0;
            for (int i = 0; i < answers_tab.Length; i++)
            {
                answers_tab[i] = random.Next(0, 2);
            }

            for (int i = 0; i < answers_tab.Length; i++)
            {
                sum_tab += answers_tab[i];
            }

            // Konwertujemy na zmienną typu double, żeby kompilator nie ucinał części ułamkowej
            var score = (double) sum_tab / answers_tab.Length; 

            Console.WriteLine($"{sum_tab} na {answers_tab.Length} punktow. Wynik: {score}");

            // Korzystamy z funkcji ScanTest, a jej wynik przypisujemy do zmiennej answers
            var answers = ScanTest();

            var score_function = CalculateScore(answers);

            for (int i = 0; i < 5; i++)
            {
                answers = ScanTest();
                score_function = CalculateScore(answers);
                Console.WriteLine($"Ostateczny wynik to: {score_function}");
            }
            // Tworzymy obiekt normalStudent, który jest instancją klasy Student
            // W trakcie tworzenia obiektu, wywoływany jest konstruktor Student(), któremu przekazujemy 2 parametry
            Student normalStudent = new Student("123456", 3.4);
            Student normalStudent2 = new Student("123456", 3.4);
            
            // Wywołujemy metodę(funkcje w obrębie klasy) Print, która należy do klasy Student
            // Wywołujemy ją z poziomu obiektu normalStudent
            normalStudent.Print();
            //Console.WriteLine($"{normalStudent.Grade}");
            // Przypisujemy nową wartość do pola Grade, pokazując w jaki sposób logika zawarta w metodzie "set" zabrania nam
            // ustawienia błędnej wartości
            normalStudent.Grade = 6.0;
            normalStudent.Print();

            // Przypisujemy referencje normalStudent2 do nazwy normalStudent3
            // normalStudent3 i normalStudent2 wskazują na ten sam obiekt
            Student normalStudent3 = normalStudent2;

            // Mimo tego, że normalStudent i normalStudent2 mają takie same wartości pól, nie są sobie równe, ponieważ to dwa inne obiekty
            Console.WriteLine(normalStudent == normalStudent2);
            // Jednakże, jeżeli normalStudent3 i normalStudent2 wskazują na ten sam obiekt -> to są sobie równe
            Console.WriteLine(normalStudent3 == normalStudent2);


            // Korzystanie z klas i obiektów pozwala nam na uporządkowanie i zgrupowanie pewnych cech/właściwości/czynności
            // które są ze sobą w jakiś sposób powiązane
            // W tym przypadku wiemy, że StudentNumber oraz Grade należą do tego samego studenta normalStudent

            //normalStudent.StudentNumber = "123456";
            //normalStudent.StudentNumber2 = "123456";
            //normalStudent.Grade = 3.0;

            // W tym przypadku nie wiemy, czy zmienne studentNumber oraz studentGrade są ze sobą jakkolwiek powiązane
            // Jeżeli uznamy, że mają ze sobą związek - to naszym zadaniem jest o tym wszędzie pamiętać, co utrudnia pracę
            //string studentNumber = "123456";
            //double studentGrade = 3.4;


        }

        // Nagłówek funkcji: public static <typ zwracanej zmiennej> <nazwa funkcji>(<parametry>)
        public static int[] ScanTest()
        {
            var answers = new int[30];

            Random random = new Random();

            for (int i = 0; i < answers.Length; i++)
            {
                answers[i] = random.Next(0, 2);
            }

            // Return to słowo kluczowe, który mówi kompilatorowi, że ma wrócić do miejsca, z którego wszedł do tej funkcji
            // Jeżeli funkcja zwraca jakąś wartość, to za pomocą return możemy powiedzieć kompilatorowi jaką wartość ma zwrócić
            return answers;
        }

        public static double CalculateScore(int[] answers)
        {
            int sum = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                sum += answers[i];
            }

            double score = (double) sum / answers.Length;

            return score;
        }

    }
}
