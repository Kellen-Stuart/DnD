namespace Monster.SenseAbstraction
{
    public class PassivePerception : Sense
    {
        public int Rating { get; private set; }
        
        public PassivePerception(int rating)
        {
            Rating = rating;
        }
    }
}