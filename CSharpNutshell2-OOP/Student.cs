using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNutshell2_OOP
{
    class Student
    {
        public string StudentNumber;

        // Poniżej mamy 2 rodzaje tworzenia właściwości w C#
        // Pierwsza z nich jasno określa do jakiego pola i w jaki sposób przypisujemy, lub pobieramy wartość
        // Druga opcja tworzy tę zależność "automatycznie" w trakcie kompilacji programu

        //public string StudentNumber2
        //{
        //    get => _studentNumber2;
        //    set => _studentNumber2 = value;
        //}
        public string StudentNumber2 { get; set; }


        //private int _test;

        //public int getTest()
        //{
        //    return _test;
        //}

        //public void setTest(int value)
        //{
        //    _test = value;
        //}
        //public int test { get;  }

        // Właściwości w C# pozwalają nam również tworzyć własną logikę przy metodach set/get
        // Tak jak w poniższym przypadku, nie potrzebujemy nawet tworzyć zmiennej _hasScholarship, ponieważ właściwość HasScholarship
        // zwraca wartość true/false na podstawie innej właściwości
        public bool HasScholarship
        {
            get
            {
                if (Grade > 4.5)
                {
                    return true;
                }

                return false;
            }
        }

        private double _grade;
        private string _studentNumber2;

        // Jak wyżej, właściwości pozwalają nam na "dokładanie" własnej logiki, co pozwala nam np. chronić właściwość przed otrzymywaniem
        // błędnych wartości
        public double Grade
        {
            get { return _grade; }
            set
            {
                if (value <= 5.0)
                {
                    _grade = value;
                }
            }
        }
        // Podstawowy konstruktor bezparametrowy. Jeżeli nie podamy żadnego konstruktora, to kompilator sam doda poniższy konstruktor do klasy
        // Jednak, jeśli stworzymy jakikolwiek konstruktor, to kompilator żadnego więcej "dopisywać" już nie będzie
        public Student()
        {

        }
        // Konstruktor klasy Student, który przyjmuje 2 parametry i ustawia wartości pól w nowym obiekcie
        public Student(string studentNumber, double grade)
        {
            StudentNumber = studentNumber;
            Grade = grade;
        }

        public Student(string studentNumber)
        {
            StudentNumber = studentNumber;
        }
        // Metoda Print, która nie zwraca żadnych wartości, ale wypisuje na ekran konsoli informacje o studencie
        public void Print()
        {
            Console.WriteLine($"Student o numerze {StudentNumber} i ocenie {Grade}");
            Console.WriteLine($"Stypendium: {HasScholarship}");
        }

    }
}
