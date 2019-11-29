using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.Conditions;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Languages;
using Common.Actions;
using Common.Armor;
using PassiveSkill = Common.Abstractions.PassiveSkills.PassiveSkill;
using Sense = Common.Abstractions.Senses.Sense;

namespace Common
{
    public abstract class Character : PhysicalObject
    {
        public int Level { get; private set; }

        public int Speed { get; set; }

        public Common.Abilities.Abilities Abilities { get; set; }

        public Common.Abilities.Abilities.AbilityEnum SpellCastingAbility { get; set; }

        public Abstractions.SavingThrows.SavingThrows SavingThrows { get; set; }

        public IEnumerable<Sense> Senses { get; set; }

        public IEnumerable<Language> Languages { get; set; }

        public Abstractions.Challenge.Challenge Challenge { get; set; }

        public IEnumerable<PassiveSkill> PassiveSkills { get; set; }

        public IEnumerable<IAction> Actions { get; set; }

        public IEnumerable<IAction> BasicActions { get; set; }

        public int Reach { get; set; }

        public int Initiative => Abilities.Dexterity.Modifier + _initiativeRoll;

        private  int _initiativeRoll => Dice.Dice.Roll(20, 1);

        public int RollToHit => Dice.Dice.Roll(20, 1) +
                                ProficiencyBonus.LookupProficiencyBonusByLevel(Level);

        public Character(
            int armorClass,
            int hitPoints,
            int speed,
            Common.Abilities.Abilities abilities,
            Common.Abilities.Abilities.AbilityEnum spellCastingAbility,
            Abstractions.SavingThrows.SavingThrows savingThrows,
            IEnumerable<DamageType> damageResistances,
            IEnumerable<DamageType> damageImmunities,
            IEnumerable<Condition> conditionImmunities,
            IEnumerable<Sense> senses,
            IEnumerable<Language> languages,
            Abstractions.Challenge.Challenge challenge,
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
        }
    }
}