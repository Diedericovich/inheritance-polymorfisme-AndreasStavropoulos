namespace Animals
{
    public abstract class Animal
    {
        private string _name;

        protected string Name
        {
            get { return _name; }
        }

        protected Animal(string name)
        {
            _name = name;
        }

        public virtual string Eat()
        {
            return "";
        }

        public virtual string Talk(string sentence)
        {
            return "";
        }

        public virtual string Pet()
        {
            return "";
        }
    }
}