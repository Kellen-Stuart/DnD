using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dice;
using Monster.ChallengeAbstraction;
using Monster.ConditionAbstraction;
using Monster.DamageAbstraction;
using Monster.LanguageAbstraction;
using Monster.Monsters;
using Monster.PassiveSkillsAbstraction;
using Monster.SavingThrowsAbstraction;
using Monster.SenseAbstraction;
using Action = Monster.ActionAbstraction.Action;

namespace Monster.MonsterAbstraction
{
    public abstract class Monster
    {
        public ArmorClass ArmorClass { get; private set; }

        public int HitPoints { get; private set; }

        public int Speed { get; private set; }

        public AbilityAbstraction.Abilities Abilities { get; private set; }

        public SavingThrows SavingThrows { get; private set; }

        public IEnumerable<DamageType> DamageResistances { get; private set; }

        public IEnumerable<DamageType> DamageImmunities { get; private set; }

        public IEnumerable<Sense> Senses { get; private set; }

        public IEnumerable<Language> Languages { get; private set; }

        public Challenge Challenge { get; private set; }
        
        public IEnumerable<PassiveSkill> PassiveSkills { get; private set; }

        public IEnumerable<Action> Actions { get; private set; }
        
        public int Initiative => Abilities.Dexterity.Modifier + _initiativeRoll;

        private readonly int _initiativeRoll = Dice.Dice.Roll(20, 1);


        public Monster(
            ArmorClass armorClass,
            int hitPoints,
            int speed,
            AbilityAbstraction.Abilities abilities,
            SavingThrows savingThrows,
            IEnumerable<DamageType> damageResistances,
            IEnumerable<DamageType> damageImmunities,
            IEnumerable<Condition> conditionImmunities,
            IEnumerable<Sense> senses,
            IEnumerable<Language> languages,
            Challenge challenge,
            IEnumerable<Action> actions, IEnumerable<PassiveSkill> passiveSkills)
        {
            ArmorClass = armorClass;
            HitPoints = hitPoints;
            Speed = speed;
            Abilities = abilities;
            SavingThrows = savingThrows;
            DamageResistances = damageResistances;
            DamageImmunities = damageImmunities;
            Languages = languages;
            Challenge = challenge;
            Actions = actions;
            PassiveSkills = passiveSkills;
        }

        public void TakeDamage(int damage, DamageType damageType, int numberOfHits = 1)
        {
            // Immunity
            if (this.IsImmuneTo(damageType))
                return;

            // Resistance
            if (this.IsResistantTo(damageType))
            {
                HitPoints -= (damage / 2);
                return;
            }

            // Condition?

            HitPoints -= damage;
        }

        public bool IsImmuneTo(DamageType damageType)
        {
            if (DamageImmunities.Contains(damageType))
                return true;

            return false;
        }

        public bool IsResistantTo(DamageType damageType)
        {
            if (DamageResistances.Contains(damageType))
                return true;

            return false;
        }
    }
}