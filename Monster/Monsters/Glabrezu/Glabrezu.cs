using System.Collections.Generic;
using Monster.AbilityAbstraction;
using Monster.ActionAbstraction;
using Monster.ChallengeAbstraction;
using Monster.ConditionAbstraction;
using Monster.DamageAbstraction;
using Monster.LanguageAbstraction;
using Monster.MonsterAbstraction;
using Monster.PassiveSkillsAbstraction;
using Monster.SavingThrowsAbstraction;
using Monster.SenseAbstraction;

namespace Monster.Monsters
{
    public class Glabrezu : MonsterAbstraction.Monster
    {
        public Glabrezu() :
            base(
                armorClass: new ArmorClass(17),
                hitPoints: Dice.Dice.Roll(
                               numberOfSides: 10,
                               rolls: 15
                           ) + 75,
                speed: 40,
                abilities: new AbilityAbstraction.Abilities(
                    strength: new Strength(20, 5),
                    dexterity: new Dexterity(15, 2),
                    constitution: new Constitution(21, 5),
                    intelligence: new Intelligence(19, 4),
                    wisdom: new Wisdom(17, 3),
                    charisma: new Charisma(16, 3)
                ),
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
                    new TrueSight(),
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
                actions: new List<Action>
                {
                    new MultiAttack(),
                    new Pincer(),
                    new Fist(),
                    new SummonDemon()
                }
            )
        {
        }
    }
}