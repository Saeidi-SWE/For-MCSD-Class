using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Exam exam = new Exam();
            exam.Questions = new Question[]
            {
                new Question() { Text = "Question 1" },
                new Question() { Text = "Question 2" },
                new Question() { Text = "Question 3" },
                new Question() { Text = "Question 4" },
                new Question() { Text = "Question 5" },
                new Question() { Text = "Question 6" },
                new Question() { Text = "Question 7" },
                new Question() { Text = "Question 8" },
                new Question() { Text = "Question 9" },
                new Question() { Text = "Question 10" },
                new Question() { Text = "Question 11" },
                new Question() { Text = "Question 12" },
                new Question() { Text = "Question 13" },
                new Question() { Text = "Question 14" },
                new Question() { Text = "Question 15" },
                new Question() { Text = "Question 16" },
                new Question() { Text = "Question 17" },
                new Question() { Text = "Question 18" },
                new Question() { Text = "Question 19" },
                new Question() { Text = "Question 20" }

            };

            foreach (Question question in exam)
            {
                Console.WriteLine(question.Text);
            }

            Console.ReadKey();
        }
    }
}
