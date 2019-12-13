using System.Collections.Generic;
using System.Drawing;
using Common;
using Common.Abilities;
using Common.Abstractions.Challenge;
using Common.Abstractions.Conditions;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Languages;
using Common.Abstractions.SavingThrows;
using Common.Abstractions.Senses;
using Common.Actions.Abstractions;
using Common.PassiveSkills;
using Size = Common.Abstractions.Size.Size;

namespace Entity
{
    public class Kobold
    {
        static void Main(string[] args)
        {
            using (var context = new DnDContext())
            {
                var kobldAbilities = new Abilities(
                    strength: new Strength(7, -2),
                    dexterity: new Dexterity(15, 2),
                    constitution: new Constitution(9, -1),
                    intelligence: new Intelligence(8, -1),
                    wisdom: new Wisdom(7, -2),
                    charisma: new Charisma(8, -1));

                Character kobold = new Character(
                    size: Size.Small,
                    armorClass: 12,
                    speed: 30,
                    hitDice: new Dice(2, 6, -2),
                    damageResistances: new List<DamageType>(),
                    damageImmunities: new List<DamageType>(),
                    pointOnMap: new Point(),
                    abilities: kobldAbilities,
                    conditionImmunities: new List<Condition>(),
                    senses: new List<Sense>
                    {
                        // Darkvision
                    },
                    languages: new List<Language>
                    {
                        Language.Common,
                        Language.Draconic
                    },
                    challenge: new Challenge(0.125m, 25),
                    passiveSkills: new List<PassiveSkill>
                    {
                        // todo - create passive skills
                    },
                    actions: new List<IAction>
                    {
                        // todo
                    },
                    spellCastingAbility: Abilities.AbilityEnum.Charisma,
                    savingThrows: new SavingThrows(), // todo
                    reach: 5
                );

                context.Characters.Add(kobold);
                context.SaveChanges();
            }
        }
    }
}