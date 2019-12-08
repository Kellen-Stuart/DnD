using System.Collections.Generic;
using System.Drawing;
using Common;
using Common.Abilities;
using Common.Abstractions.Challenge;
using Common.Abstractions.Conditions;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Languages;
using Common.Abstractions.Senses;
using Common.Abstractions.Size;
using Common.Actions.Abstractions;
using Common.PassiveSkills;

namespace Entity
{
    public class Kobold
    {
        static void Main(string[] args)
        {
            using (var context = new DnDContext())
            {
                Character kobold = new Character(
                    size: SizeEnum.Small,
                    armorClass: 12,
                    hitPoints: 5,
                    damageResistances: new List<DamageType>(),
                    damageImmunities: new List<DamageType>(),
                    pointOnMap: new Point(),
                    speed: 30,
                    abilities: new Abilities(
                        strength: new Strength(7, -2),
                        dexterity: new Dexterity(15, 2),
                        constitution: new Constitution(9, -1),
                        intelligence: new Intelligence(8, -1),
                        wisdom: new Wisdom(7, -1),
                        charisma: new Charisma(8, -1)
                    ),
                    conditionImmunities: new List<Condition>(),
                    senses: new List<Sense>(),
                    languages: new List<Language>
                    {
                        Language.Common,
                        Language.Draconic
                    },
                    challenge: new Challenge(0.125m, 25),
                    passiveSkills: new List<PassiveSkill>
                    {
                        // todo
                    },
                    actions: new List<IAction>
                    {
                        
                    },

                    reach: 5
            );

                context.Characters.Add(kobold);
                context.SaveChanges();
            }
        }
    }
}