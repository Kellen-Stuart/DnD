using System;
using System.Collections.Generic;
using System.Linq;
using Common.Abstractions.Actions;
using Common.Abstractions.Actions.Basic;
using Common.Abstractions.Armor;
using Common.Abstractions.Conditions;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Languages;
using PassiveSkill = Common.Abstractions.PassiveSkills.PassiveSkill;
using Sense = Common.Abstractions.Senses.Sense;

namespace Common.Abstractions.Character
{
    public abstract class Character : PhysicalObject
    {
        public ArmorClass ArmorClass { get; private set; }

        public int Speed { get; private set; }

        public Abilities.Abilities Abilities { get; private set; }

        public Abilities.Abilities.AbilityEnum SpellCastingAbility { get; private set; }

        public SavingThrows.SavingThrows SavingThrows { get; private set; }

        public IEnumerable<Sense> Senses { get; private set; }

        public IEnumerable<Language> Languages { get; private set; }

        public Challenge.Challenge Challenge { get; private set; }

        public IEnumerable<PassiveSkill> PassiveSkills { get; private set; }

        public IEnumerable<IAction> Actions { get; set; }

        public IEnumerable<IAction> BasicActions { get; set; }

        public int Reach { get; private set; }

        public int Initiative => Abilities.Dexterity.Modifier + _initiativeRoll;

        private readonly int _initiativeRoll = Dice.Dice.Roll(20, 1);


        public Character(
            ArmorClass armorClass,
            int hitPoints,
            int speed,
            Abilities.Abilities abilities,
            Abilities.Abilities.AbilityEnum spellCastingAbility,
            SavingThrows.SavingThrows savingThrows,
            IEnumerable<DamageType> damageResistances,
            IEnumerable<DamageType> damageImmunities,
            IEnumerable<Condition> conditionImmunities,
            IEnumerable<Sense> senses,
            IEnumerable<Language> languages,
            Challenge.Challenge challenge,
            IEnumerable<IAction> actions,
            IEnumerable<PassiveSkill> passiveSkills,
            System.Drawing.Size size,
            int reach)
        {
            ArmorClass = armorClass;
            HitPoints = hitPoints;
            Speed = speed;
            Abilities = abilities;
            SpellCastingAbility = spellCastingAbility;
            SavingThrows = savingThrows;
            DamageResistances = damageResistances;
            DamageImmunities = damageImmunities;
            Languages = languages;
            Challenge = challenge;
            Actions = actions;
            PassiveSkills = passiveSkills;
            Size = size;
            Reach = reach;
            
            // Basic Actions - common to every character
            BasicActions = new List<IAction>
            {
                new UnarmedStrike(Abilities.Strength.Modifier)
            };
        }
    }
}