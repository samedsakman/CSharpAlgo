namespace ClassTest
{
    public class Player
    {
        Random rand = new Random();
        public Player(string firstName, int formaNo)
        {
            FirstName = firstName;
            FormaNo = formaNo;
            Heading = rand.Next(50,100);
        }

        public string FirstName { get; set; } 

        public int FormaNo { get; set; }
        public int Heading { get; private set; }
    }
}