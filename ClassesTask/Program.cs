// See https://aka.ms/new-console-template for more information
using static System.Console;

namespace Program
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ///////////////////CHECKING CALCULATOR
            //string[] opt = { "+", "-", "*", "/" };
            //returnThere:
            //    Write("Please enter operation (3 + 3): ");
            //    string[] userInput = ReadLine().Split(' ');

            //    if (!opt.Contains(userInput[1]))
            //        goto returnThere;

            //    if (int.Parse(userInput[2]) == 0 && userInput[1] == "/")
            //    {
            //        WriteLine("Can not divide 0");
            //        goto returnThere;
            //    }

            //Calculator calc = new(int.Parse(userInput[0]), int.Parse(userInput[2]));

            //switch (userInput[1])
            //{
            //    case "+":
            //        WriteLine(calc.Add());
            //        break;
            //    case "-":
            //        WriteLine(calc.Substract());
            //        break;
            //    case "*":
            //        WriteLine(calc.Multipy());
            //        break;
            //    case "/":
            //        WriteLine(calc.Divide());
            //        break;
            //    default:
            //        WriteLine("There is not operator like that");
            //        break;
            //}

            //////////////////////CHECKING GUN
            //Gun newGun = new("AWP", 5, 1, 4, "spiner");
            //newGun.Fire();
            //newGun.ShowDetails();
            //newGun.Reload();
            //newGun.Fire();
            //newGun.Reload();
            //newGun.Fire();
            //newGun.Fire();
            //newGun.Fire();
            //newGun.Fire();
            //newGun.ShowDetails();

            //////////////////CHECKING STUDENT
            //Student newStdudent = new("Revan", "Eliyev", 20, [90, 90, 90, 65, 75], [85, 84, 86, 54, 70], [85, 84, 86, 54, 70], 90, [true, true, true, false, true]);

            //WriteLine(newStdudent.GetFinalResult());
        }

        public class Animal
        {
            string name;
            string breed;
            string color;
            int age;

            public Animal(string name, string breed, string color, int age)
            {
                this.name = name;
                this.breed = breed;
                this.color = color;
                this.age = age;
            }

            public void ShowDetails()
            {
                WriteLine($"Ad: {name}, Cins: {breed}, Reng: {color}, Yas: {age}");
            }
        }

        public class Building
        {
            string name;
            double height;
            double area;
            string address;

            public Building(string name, double height, double area)
            {
                this.name = name;
                this.height = height;
                this.area = area;
            }

            public double FindHecm()
            {
                return height * area;
            }

            public void ShowDetails()
            {
                WriteLine($"Ad: {name}, Hundurluk: {height}, Sahe: {area}, Adres: {address}, Hecmi: {FindHecm()}");
            }
        }

        public class Student
        {
            string ad;
            string soyad;
            int age;
            int[] HomeworkGrades;
            int[] ProjectGrades;
            int[] QuizGrades;
            int FinalGrade;
            bool[] Countinuty;

            public Student(string ad, string soyad, int age, int[] homeworkGrades, int[] projectGrades, int[] quizGrades, int finalGrade, bool[] countinuty)
            {
                this.ad = ad;
                this.soyad = soyad;
                this.age = age;
                HomeworkGrades = homeworkGrades;
                ProjectGrades = projectGrades;
                QuizGrades = quizGrades;
                FinalGrade = finalGrade;
                Countinuty = countinuty;
            }

            public int GetAverage(int[] countinity)
            {
                int avg = 0;

                foreach (int i in countinity)
                {
                    avg += i;
                }

                return avg / countinity.Length;
            }

            public int GetAverage(bool[] countinity)
            {
                int avg = 0;

                foreach (bool i in countinity)
                {
                    if (i)
                        avg++;
                }

                return (avg * 100) / countinity.Length;
            }

            public double GetFinalResult()
            {
                double homeAvrg = GetAverage(HomeworkGrades) * 0.2;
                double projectAvrg = GetAverage(ProjectGrades) * 0.2;
                double quizAvrg = GetAverage(QuizGrades) * 0.2;
                double finalAvrg = FinalGrade * 0.3;
                double countintyAvrg = GetAverage(Countinuty) * 0.1;

                double finalResult = homeAvrg + projectAvrg + quizAvrg + finalAvrg + countintyAvrg;

                return finalResult;
            }
        }

        public class Gun
        {
            string name;
            int maxCapacity;
            int currentBullet;
            int totalBullet;
            string type;

            public Gun(string name, int maxCapacity, int currentBullet, int totalBullet, string type)
            {
                if (currentBullet > maxCapacity)
                {
                    throw new ArgumentException("Current bullet can not be higher than max capacity");
                }
                if (!(new string[] {"assult", "sniper"}.Contains(type)))
                {
                    throw new ArgumentException("There is no type like that");
                }
                this.name = name;
                this.maxCapacity = maxCapacity;
                this.currentBullet = currentBullet;
                this.totalBullet = totalBullet;
                this.type = type;
            }

            public void Fire()
            {
                if (currentBullet == 0)
                {
                    WriteLine("You can not fire");
                    return;
                }
                if (type == "assult")
                {
                    currentBullet = 0;
                }
                else
                {
                    currentBullet--;
                }
            }

            public void Reload()
            {
                if (currentBullet == maxCapacity)
                    return;
                else
                {
                    if (totalBullet < maxCapacity - currentBullet && totalBullet != 0)
                    {
                        currentBullet = totalBullet;
                        totalBullet = 0;
                    }
                    else if (totalBullet > maxCapacity - currentBullet)
                    {
                        totalBullet -= maxCapacity - currentBullet;
                        currentBullet = maxCapacity;
                    }
                    else
                    {
                        WriteLine("You can not reload");
                    }
                }
            }

            public void ShowDetails()
            {
                WriteLine($"Ad: {name}, Hazirki gulle: {currentBullet}, Umumi gulle: {totalBullet}, Tip: {type}");
            }
        }

        public class Calculator
        {
            int num1;
            int num2;

            public Calculator(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            public int Add()
            {
                return num1 + num2;
            }

            public int Substract()
            {
                return num1 - num2;
            }

            public int Multipy()
            {
                return num1 * num2;
            }

            public int Divide()
            {
                return num1 / num2;
            }
        }
    }
}
