using System;

namespace Assets.Scripts
{
    class AnswerVars
    {
        public int btnValue1 { get; private set; }
        public int btnValue2 { get; private set; }
        public int btnValue3 { get; private set; }
        public int correctBtnNumber { get; private set; }
        private int correctAnswer;
        private int _max;
        private int _incorrectBtn1;
        private int _incorrectBtn2;
        private string _equasion;
        private string[] split;
        private readonly Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public AnswerVars(int max, string equasion)
        {
            _max = max;
            _equasion = equasion;
        }
        public void CorrectAnswer()
        {
            split = _equasion.Split(new char [] { ' ' });
            Count();
            Fill();
            SetCorrectBtn();
        }
        private void Count()
        {
            var oper1 = Convert.ToInt32(split[0]);
            var oper2 = Convert.ToInt32(split[2]);
            switch (split[1])
            {
                case "+":
                    correctAnswer = oper1 + oper2;
                    break;
                case "-":
                    correctAnswer = oper1 - oper2;
                    break;                    
            }
        }
        private void Fill()
        {
            _incorrectBtn1 = rnd.Next(0, _max);
            _incorrectBtn2 = rnd.Next(0, _max);
        }
        private void SetCorrectBtn()
        {
            correctBtnNumber = rnd.Next(1, 3);
            if(correctBtnNumber == 1)
            {
                btnValue1 = correctAnswer;
                btnValue2 = _incorrectBtn2;
                btnValue3 = _incorrectBtn1;
            }
            else if (correctBtnNumber == 2)
            {
                btnValue2 = correctAnswer;
                btnValue1 = _incorrectBtn2;
                btnValue3 = _incorrectBtn1;
            }
            else if (correctBtnNumber == 3)
            {
                btnValue3 = correctAnswer;
                btnValue2 = _incorrectBtn2;
                btnValue1 = _incorrectBtn1;
            }
        }
    }
}
