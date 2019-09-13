using System.Collections.Generic;

namespace quizEngine{
    class Question{
        private string question;
        private int value;
        private List<Answer> options;
        private int correctIndex;
        
        public Question(string question, int value, List<Answer> options, int correctIndex){
            this.question = question;
            this.value = value;
            this.options = options;
            this.correctIndex = correctIndex;
        }
        public string GetString(){
            return this.question;
        }
        public List<Answer> GetOptions(){
            return options;
        }
        public int AnswerIt(int answerIndex){
            if(answerIndex == correctIndex){
                return value;
            } 
            return -1;
        }
    }

    class Question2
    {
        private string question2;
        private int value2;
        private List<Answer2> options2;
        private int correctIndex2;

        public Question2(string question2, int value2, List<Answer2> options2, int correctIndex2)
        {
            this.question2 = question2;
            this.value2 = value2;
            this.options2 = options2;
            this.correctIndex2 = correctIndex2;
        }
        public string GetString()
        {
            return this.question2;
        }
        public List<Answer2> GetOptions2()
        {
            return options2;
        }
        public int AnswerIt2(int answerIndex2)
        {
            if (answerIndex2 == correctIndex2)
            {
                return value2;
            }
            return -1;
        }
    }

    class Question3
    {
        private string question3;
        private int value3;
        private List<Answer3> options3;
        private int correctIndex3;

        public Question3(string question3, int value3, List<Answer3> options3, int correctIndex3)
        {
            this.question3 = question3;
            this.value3 = value3;
            this.options3 = options3;
            this.correctIndex3 = correctIndex3;
        }
        public string GetString()
        {
            return this.question3;
        }
        public List<Answer3> GetOptions3()
        {
            return options3;
        }
        public int AnswerIt3(int answerIndex3)
        {
            if (answerIndex3 == correctIndex3)
            {
                return value3;
            }
            return -1;
        }
    }
}