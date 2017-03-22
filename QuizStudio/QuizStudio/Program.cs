using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio7Quiz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string theAnswer = "F";
            string x = "Cheese is good?";

            TrueFalseQuestion cheesy = new TrueFalseQuestion(theAnswer, x);

            Console.WriteLine(cheesy.QuestionString);
            string usersAnswer = Console.ReadLine();

            if (usersAnswer != cheesy.AnswerString)
            {
                Console.WriteLine("You got it wrong");
            }
            else
            {
                Console.WriteLine("You got it right");
            }
            Console.ReadLine();


            string anotherAnswer = "chalkboard";
            string anotherQuestion = "What is in front of us?";
            string[] thePossibleAnswers = { "chalkboard", "elephant", "Statue of Liberty" };

            MultipleChoiceQuestion chalky = new MultipleChoiceQuestion(anotherAnswer, anotherQuestion, thePossibleAnswers);
            //MultipleChoiceQuestion t = new MultipleChoiceQuestion(anotherAnswer, anotherQuestion, thePossibleAnswers);
            // these call down to MultipleChoiceQuestion : GeneralQuestion
            //t.PossibleAnswers
            Console.WriteLine(chalky.QuestionString);
            foreach (string aPossibleAnswer in chalky.PossibleAnswers)
            {
                Console.WriteLine(aPossibleAnswer);
            }
            string studentsAnswer = Console.ReadLine();

            if (studentsAnswer == chalky.AnswerString)
            {
                Console.WriteLine("You're smart");
            }
            else
            {
                Console.WriteLine("You're dumb");
            }
            Console.ReadLine();

            string moreAnswer = "ab";
            string moreQuestion = "What's blue?";
            string[] morePossibleAnswers = { "a) ocean", "b) carpet", "c) tree" };

            CheckBoxQuestion bluey = new CheckBoxQuestion(moreAnswer, moreQuestion, morePossibleAnswers);

            Console.WriteLine(bluey.QuestionString);
            foreach (string thePossibleAnswersInBluey in bluey.PossibleAnswers)
            {
                Console.WriteLine(thePossibleAnswersInBluey);
            }
            string personsAnswer = Console.ReadLine();

            if (personsAnswer == bluey.AnswerString)
            {
                Console.WriteLine("Yessssssss");
            }
            else
            {
                Console.WriteLine("Nooooooo");
            }
            Console.ReadLine();

        }
        public class GeneralQuestion
        {
            //private fields
            private string answerString; 
            private string questionString;


            //constructor method
            public GeneralQuestion(string answerString, string questionString)
            {
                AnswerString = answerString;
                QuestionString = questionString;
            }
            //accessor methods
            public string AnswerString { get; set; }
            public string QuestionString { get; set; }
        }

        public class TrueFalseQuestion : GeneralQuestion
        {
            public TrueFalseQuestion(string answerString, string questionString) : base(answerString, questionString)
            { }


        }
        public class MultipleChoiceQuestion : GeneralQuestion
        {
            private string[] possibleAnswers;

            public MultipleChoiceQuestion(string answerString, string questionString, string[] possibleAnswers) : base(answerString, questionString)
            {
                PossibleAnswers = possibleAnswers;
            }

            public string[] PossibleAnswers { get; set; }

        }
        public class CheckBoxQuestion : MultipleChoiceQuestion
        {
            public CheckBoxQuestion(string answerString, string questionString, string[] possibleAnswers) : base(answerString, questionString, possibleAnswers)
            { }

        }
    }
}