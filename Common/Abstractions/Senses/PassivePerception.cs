namespace Common.Abstractions.Senses
{
    public class PassivePerception : Common.Abstractions.Senses.Sense
    {
        public int Rating { get; private set; }
        
        public PassivePerception(int rating)
        {
            Rating = rating;
        }
    }
}