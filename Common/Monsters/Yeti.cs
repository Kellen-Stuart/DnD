//using System.Collections.Generic;
//using System.Globalization;
//using Monster.AbilityAbstraction;
//using Monster.ActionAbstraction;
//using Monster.ChallengeAbstraction;
//using Monster.ConditionAbstraction;
//using Monster.DamageAbstraction;
//using Monster.LanguageAbstraction;
//using Monster.PassiveSkillsAbstraction;
//using Monster.SavingThrowsAbstraction;
//using Monster.SenseAbstraction;
//
//namespace Monster.Monsters.Yeti
//{
//    public class Yeti : MonsterAbstraction.Monster
//    {
//        public Yeti() :
//            base(
//                armorClass: new ArmorClass(12),
//                hitPoints: Dice.Dice.Roll(
//                               numberOfSides: 10,
//                               rolls: 6
//                           ) + 18,
//                speed: 40,
//                abilities: new AbilityAbstraction.Abilities(
//                    strength: new Strength(18, 4),
//                    dexterity: new Dexterity(13, 1),
//                    constitution: new Constitution(16, 3),
//                    intelligence: new Intelligence(8, -1),
//                    wisdom: new Wisdom(12, 1),
//                    charisma: new Charisma(7, -2)
//                ),
//                savingThrows: new SavingThrows(
//
//                ),
//                damageResistances: new List<DamageType>
//                {
//                    DamageType.Bludgeoning
//                },
//                damageImmunities: new List<DamageType>
//                {
//                    DamageType.Cold
//                },
//                conditionImmunities: null,
//                senses: new List<Sense>
//                {
//                    new Darkvision(),
//                    new PassivePerception(13)
//                },
//                languages: new List<Language>
//                {
//                    Language.Yeti
//                },
//                challenge: new Challenge(3, 700), 
//                passiveSkills: new List<PassiveSkill>
//                {
//                    new FearOfFire(),
//                    new KeenSmell(),
//                    new SnowCamouflage()
//                },
//                actions: new List<Action>
//                {
//                    new MultiAttack(),
//                    new Claw(),
//                    new ChillingGaze()
//                })
//                
//        {
//        }
//    }
//}