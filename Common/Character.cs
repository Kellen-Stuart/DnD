using System;
using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.Conditions;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Languages;
using Common.Abstractions.Size;
using Common.Actions;
using PassiveSkill = Common.Abstractions.PassiveSkills.PassiveSkill;
using Sense = Common.Abstractions.Senses.Sense;

namespace Common
{
    public abstract class Character : PhysicalObject
    {
        public int Speed { get; set; }
        public int Level { get; private set; }

        public int HitPoints { get; }
        public Common.Abilities.Abilities Abilities { get; set; }
        public Common.Abilities.Abilities.AbilityEnum SpellCastingAbility { get; set; }
        public Abstractions.SavingThrows.SavingThrows SavingThrows { get; set; }
        public IEnumerable<Sense> Senses { get; private set; }
        public IEnumerable<Language> Languages { get; set; }
        public Abstractions.Challenge.Challenge Challenge { get; set; }
        public IEnumerable<PassiveSkill> PassiveSkills { get; set; }
        public IEnumerable<IAction> Actions { get; set; }
        public IEnumerable<IAction> BasicActions { get; set; }
        public int Reach { get; set; }
        public int Initiative => Abilities.Dexterity.Modifier + _initiativeRoll;
        private int _initiativeRoll => Dice.Dice.Roll(20, 1);

        public int RollToHit => Dice.Dice.Roll(20, 1) +
                                ProficiencyBonus.LookupProficiencyBonusByLevel(Level);

        public Action<int, int, int> HitPointCalculation { get; }


        public Character(
            SizeEnum size,
            int armorClass,
            Action<int, int, int> hitPointCalculation,
            IEnumerable<DamageType> damageResistances,
            IEnumerable<DamageType> damageImmunities,
            Point pointOnMap,
            int speed,
            Common.Abilities.Abilities abilities,
            IEnumerable<Condition> conditionImmunities,
            IEnumerable<Sense> senses,
            IEnumerable<Language> languages,
            Abstractions.Challenge.Challenge challenge,
            IEnumerable<PassiveSkill> passiveSkills,
            IEnumerable<IAction> actions,
            Common.Abilities.Abilities.AbilityEnum spellCastingAbility,
            Abstractions.SavingThrows.SavingThrows savingThrows,
            int reach
        ) : base(
            size: size,
            armorClass: armorClass,
            damageImmunities: damageImmunities,
            damageResistances: damageResistances,
            pointOnMap: pointOnMap)
        {
            Speed = speed;
            Abilities = abilities;
            HitPointCalculation = hitPointCalculation;
            SpellCastingAbility = spellCastingAbility;
            SavingThrows = savingThrows;
            Languages = languages;
            Challenge = challenge;
            Actions = actions;
            PassiveSkills = passiveSkills;
            Reach = reach;


            HitPoints = Ca
        }
    }
}