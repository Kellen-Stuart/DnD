using System.Collections.Generic;
using System.Drawing;
using Common;
using Common.Abilities;
using Common.Abstractions.Challenge;
using Common.Abstractions.Conditions;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Languages;
using Common.Abstractions.SavingThrows;
using Common.Actions.Abstractions;
using Common.Actions.Attacks.Physical;
using Common.PassiveSkills;
using Common.Senses;
using Common.Weapons;
using Dagger = Common.Actions.Attacks.Physical.Dagger;
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
                    new Strength(7, -2),
                    new Dexterity(15, 2),
                    new Constitution(9, -1),
                    new Intelligence(8, -1),
                    new Wisdom(7, -2),
                    new Charisma(8, -1));

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
                        
                        // todo - create senses
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
                        // Dagger
                        // Sling
                    },
                    spellCastingAbility: Abilities.AbilityEnum.Charisma,
                    savingThrows: new SavingThrows(), // todo - create saving throws
                    reach: 5
                );
                
                kobold.Actions.Add(new Dagger(kobold));

                context.Characters.Add(kobold);
                context.SaveChanges();
            }
        }
    }
}