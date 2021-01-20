namespace Animals
{
    internal class Cat : Animal
    {
        private int _times;

        public Cat(string name) : base(name)
        {
        }

        public override string Talk(string sentence)
        {
            _times++;
            if ((_times % 3) == 0)
            {
                return "Miaooow!";
            }
            else
            {
                return base.Talk(sentence);
            }
        }

        public override string Pet()
        {
            return "RrrRrr!";
        }
    }
}