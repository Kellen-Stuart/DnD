using System;
using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.Conditions;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Languages;
using Common.Actions.Abstractions;
using Common.Actions.Attacks.Physical;
using PassiveSkill = Common.PassiveSkills.PassiveSkill;
using Sense = Common.Senses.Sense;
using Size = Common.Abstractions.Size.Size;

namespace Common
{
    public class Character : PhysicalObject
    {
        public int Speed { get; set; }
        public int Level { get; private set; }
        public Common.Abilities.Abilities Abilities { get; set; }
        public Common.Abilities.Abilities.AbilityEnum SpellCastingAbility { get; set; }
        public Abstractions.SavingThrows.SavingThrows SavingThrows { get; set; }
        public ICollection<Sense> Senses { get; private set; }
        public ICollection<Language> Languages { get; set; }
        public Abstractions.Challenge.Challenge Challenge { get; set; }
        public ICollection<PassiveSkill> PassiveSkills { get; set; }
        public ICollection<IAction> Actions { get; set; }
        public int Reach { get; set; }
        public readonly int Initiative;

        public readonly int PassivePerception;

        public int RollToHit => Dice.Roll(20, 1) +
                                ProficiencyBonus.LookupProficiencyBonusByLevel(Level);

        public Character(
            Size size,
            int armorClass,
            Dice hitDice,
            ICollection<DamageType> damageResistances,
            ICollection<DamageType> damageImmunities,
            Point pointOnMap,
            int speed,
            Common.Abilities.Abilities abilities,
            ICollection<Condition> conditionImmunities,
            ICollection<Sense> senses,
            ICollection<Language> languages,
            Abstractions.Challenge.Challenge challenge,
            ICollection<PassiveSkill> passiveSkills,
            ICollection<IAction> actions,
            Common.Abilities.Abilities.AbilityEnum spellCastingAbility,
            Abstractions.SavingThrows.SavingThrows savingThrows,
            int reach
        ) : base(
            size: size,
            hitDice: hitDice,
            armorClass: armorClass,
            damageImmunities: damageImmunities,
            damageResistances: damageResistances,
            pointOnMap: pointOnMap)
        {
            Speed = speed;
            Abilities = abilities;
            SpellCastingAbility = spellCastingAbility;
            SavingThrows = savingThrows;
            Languages = languages;
            Challenge = challenge;
            PassiveSkills = passiveSkills;
            Reach = reach;


            // Add all the "base" actions that every character has access to
            Actions = new List<IAction> {new UnarmedStrike(this)};

            foreach (var action in actions)
            {
                Actions.Add(action);
            }
            
            //------------------------------------
            // Calculations
            //------------------------------------
            Initiative = Calculate.Initiative(Abilities.Dexterity.Modifier);
            PassivePerception = Calculate.PassivePerception(Abilities.Wisdom.Modifier);
        }
    }
}