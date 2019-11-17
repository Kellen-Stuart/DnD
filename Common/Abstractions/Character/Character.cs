using System.Collections.Generic;
using System.Linq;
using Common.Abstractions.Actions;
using Common.Abstractions.Armor;
using Common.Abstractions.Conditions;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Languages;
using Monster.PassiveSkillsAbstraction;
using Monster.SavingThrowsAbstraction;
using Monster.SenseAbstraction;
using PassiveSkill = Common.Abstractions.PassiveSkills.PassiveSkill;
using Sense = Common.Abstractions.Senses.Sense;

namespace Common.Abstractions.Character
{
    public abstract class Character : PhysicalObject
    {
        public ArmorClass ArmorClass { get; private set; }

        public int Speed { get; private set; }

        public Abilities.Abilities Abilities { get; private set; }

        public SavingThrows.SavingThrows SavingThrows { get; private set; }

        public IEnumerable<Sense> Senses { get; private set; }

        public IEnumerable<Language> Languages { get; private set; }

        public Challenge.Challenge Challenge { get; private set; }

        public IEnumerable<PassiveSkill> PassiveSkills { get; private set; }

        public int Initiative => Abilities.Dexterity.Modifier + _initiativeRoll;

        private readonly int _initiativeRoll = Dice.Dice.Roll(20, 1);


        public Character(
            ArmorClass armorClass,
            int hitPoints,
            int speed,
            Abilities.Abilities abilities,
            SavingThrows.SavingThrows savingThrows,
            IEnumerable<DamageType> damageResistances,
            IEnumerable<DamageType> damageImmunities,
            IEnumerable<Condition> conditionImmunities,
            IEnumerable<Sense> senses,
            IEnumerable<Language> languages,
            Challenge.Challenge challenge,
            IEnumerable<Action> actions, IEnumerable<PassiveSkill> passiveSkills,
            Point pointOnMap)
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
            PointOnMap = pointOnMap;
        }

        public void TakeDamage(int damage, DamageType damageType, int numberOfHits = 1)
        {
            // Immunity
            if (this.ImmuneTo(damageType))
                return;

            // Resistance
            if (this.ResistantTo(damageType))
            {
                HitPoints -= (damage / 2);
                return;
            }

            // Condition?

            HitPoints -= damage;
        }

        public bool ImmuneTo(DamageType damageType)
        {
            if (DamageImmunities.Contains(damageType))
                return true;

            return false;
        }

        public bool ResistantTo(DamageType damageType)
        {
            if (DamageResistances.Contains(damageType))
                return true;

            return false;
        }
    }
}