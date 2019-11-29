using System.Collections.Generic;
using Common.Abilities;
using Common.Abstractions.Challenge;
using Common.Abstractions.Conditions;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Languages;
using Common.Abstractions.PassiveSkills;
using Common.Abstractions.SavingThrows;
using Common.Abstractions.Senses;
using Common.Actions;
using Common.Actions.Attacks;

namespace Common.Monsters
{
    public class Glabrezu : Character
    {
        public Glabrezu() :
            base(
                armorClass: 17,
                hitPoints: Dice.Dice.Roll(
                               numberOfSides: 10,
                               rolls: 15
                           ) + 75,
                speed: 40,
                abilities: new Abilities.Abilities(
                    strength: new Strength(20, 5),
                    dexterity: new Dexterity(15, 2),
                    constitution: new Constitution(21, 5),
                    intelligence: new Intelligence(19, 4),
                    wisdom: new Wisdom(17, 3),
                    charisma: new Charisma(16, 3)
                ),
                spellCastingAbility: Common.Abilities.Abilities.AbilityEnum.Intelligence,
                savingThrows: new SavingThrows(
                    strengthModifier: 9,
                    constitutionModifier: 9,
                    wisdomModifier: 7,
                    charismaModifier: 7),
                damageResistances: new List<DamageType>
                {
                    DamageType.Cold,
                    DamageType.Fire,
                    DamageType.Lightning,
                    DamageType.Bludgeoning,
                    DamageType.Piercing,
                    DamageType.Slashing
                },
                damageImmunities: new List<DamageType>
                {
                    DamageType.Poison
                },
                conditionImmunities: new List<Condition>
                {
                    Condition.Poisoned
                },
                senses: new List<Sense>
                {
                    //new TrueSight(),
                    new PassivePerception(13)
                },
                languages: new List<Language>
                {
                    Language.Abyssal,
                    Language.Telepathy
                },
                challenge: new Challenge(9, 5000),
                passiveSkills: new List<PassiveSkill>
                {
                    new InnateSpellcasting(),
                    new MagicResistance()
                },
                actions: null,
                size: new System.Drawing.Size(10, 10),
                reach: 10
            )
        {
            Actions = new List<IAction>
            {
                new UnarmedStrike(this)
            };

            Level = 10;
        }
    }
}