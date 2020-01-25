using System;

namespace Assets.Scripts
{
    class Equasion
    {
        public int max;
        public int oper1;
        public int oper2;
        public string equasion;
        private readonly Random random = new Random(Guid.NewGuid().GetHashCode());

        public string CountEquasion(int max)
        {
            this.max = max;
            EquasionDo();
            return equasion;
        }

        private void EquasionDo()
        {
            string action;
            do
            {
                action = Action();
                oper1 = random.Next(0, max);
                oper2 = random.Next(0, max);
            }
            while (oper1 + oper2 > 20 || oper1 - oper2 < 0);
            equasion = $"{oper1} {action} {oper2}";
        }
        private string Action()
        {
            string action;
            if (random.Next(0, 100) <= 49) action = "+";
            else action = "-";
            return action;
        }
    }
}
