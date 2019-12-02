using Common;
using Common.Abstractions.Size;
using Common.Armor;

namespace Entity
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DnDContext())
            {
                // Use this when you want to save to DB
                var kobold = new Character(
                    size: SizeEnum.Small,
                    armorClass: 12,
                    hitPoints: 
                    );
                // context.Characters.Add(glabrezu);
                // context.SaveChanges();

            }
        }
    }
}