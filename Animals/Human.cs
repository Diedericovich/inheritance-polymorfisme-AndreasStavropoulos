namespace Animals
{
    public class Human : Animal
    {
        public Human(string name) : base(name)
        {
        }

        public override string Eat()
        {
            return "Mmhh, yummy!";
        }

        public override string Talk(string sentence)
        {
            switch (sentence)
            {
                case "Hello":
                    return "Oh hi! How do you do?";

                case "How are you today?":
                    return "Im fine. Thank you! You?";

                case "Are you hungry?":
                    return "Very! I could eat a cow.";
                case "What's your name?":
                    return $"My name is {Name}";
                case "How much is 10 + 12?":
                    return "22!";
                case "Which colour is your hair?":
                    return "Brown";
                case "Do you have hair?":
                    return "Nope.";
                default:
                    return "Whatever, man...";
            }
        }

        public override string Pet()
        {
            return "EEEEh! What are you doing!?";
        }
    }
}