using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Exam : IEnumerable
    {
        public Question[] Questions { get; set; }

        public IEnumerator GetEnumerator()
        {
            return new ExamEnumerator(Questions);
        }
    }

    class ExamEnumerator : IEnumerator
    {
        private Question[] questions;

        public ExamEnumerator(Question[] _questions)
        {
            questions = _questions;
        }

        private int currentIndex = -1;
        public object Current
        {
            get
            {
                return questions[currentIndex];
            }
        }

        public bool MoveNext()
        {
            int[] randomNumbers = new int[10];
            Random r = new Random();
            for (int i = 0; i < randomNumbers.Length;)
            {
                var randomNumber = r.Next(1, 21);
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (randomNumbers[j] == randomNumber)
                    {
                        isUnique = false;
                        break;
                    }

                }

                if (isUnique)
                    randomNumbers[i++] = randomNumber;
            }
            currentIndex += randomNumbers[i];
            return currentIndex < questions.Length;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
