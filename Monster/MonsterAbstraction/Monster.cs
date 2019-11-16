using System.Collections;
using System.Collections.Generic;
using Dice;
using Monster.ActionAbstraction;
using Monster.ChallengeAbstraction;
using Monster.ConditionAbstraction;
using Monster.DamageAbstraction;
using Monster.LanguageAbstraction;
using Monster.SavingThrowsAbstraction;
using Monster.SenseAbstraction;

namespace Monster.MonsterAbstraction
{
    public abstract class Monster
    {
        public ArmorClass ArmorClass { get; private set; }

        public HitPoints HitPoints { get; private set; }

        public Speed Speed { get; private set; }

        public AbilityAbstraction.Abilities Abilities { get; private set; }

        public SavingThrows SavingThrows { get; private set; }

        public IEnumerable<DamageType> DamageResistances { get; private set; }

        public IEnumerable<DamageType> DamageImmunities { get; private set; }

        public IEnumerable<Sense> Senses { get; private set; }

        public IEnumerable<Language> Languages { get; private set; }

        public Challenge Challenge { get; private set; }

        public IEnumerable<Action> Actions { get; private set; }
        
        public int Initiative => Abilities.Dexterity.Modifier + _initiativeRoll;

        private readonly int _initiativeRoll = D20.Roll();


        public Monster(
            ArmorClass armorClass,
            HitPoints hitPoints,
            Speed speed,
            AbilityAbstraction.Abilities abilities,
            SavingThrows savingThrows,
            IEnumerable<DamageType> damageResistances,
            IEnumerable<DamageType> damageImmunities,
            IEnumerable<Conditions> conditionImmunities,
            IEnumerable<Sense> senses,
            IEnumerable<Language> languages,
            Challenge challenge,
            IEnumerable<Action> actions)
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
        }
    }
}