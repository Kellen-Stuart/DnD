// Creating tables
Table Abilities {
  Id guid [pk]
  CharacterId guid [ref: > Characters.Id]
  AbilityId guid [ref: > Ability.Id]
  BaseScore int
  Modifier int
}

Table Ability {
  Id guid [pk]
  Name varchar // e.g. Strength, Charisma
}

Table Characters {
  Id guid [pk]
  ArmorClass int
  HitPoints int
  Speed int
  SwimSpeed int
  Challenge guid [ref: > Challenge.Id]
}

Table Immunities {
  Id guid [pk]
  CharacterId guid [ref: > Characters.Id]
  ImmunityId guid [ref: > DamageTypes.Id]
}

Table Resistances {
  Id guid [pk]
  CharacterId guid [ref: > Characters.Id]
  ResistanceId guid [ref: > DamageTypes.Id]
}

Table DamageTypes {
  Id guid [pk]
  DamageType varchar
}

Table Senses {
  Id guid [pk]
  SenseId guid [ref: > Sense.Id]
}

Table Sense {
  Id guid [pk]
  // needs defining - this could be complicated
}

Table Challenge {
  Id guid [pk]
  Level int
  Experience int
}

Table Actions {
  Id guid [pk]
  CharacterId guid [ref: > Characters.Id]
  ActionId guid [ref: > Action.Id]
}

Table Action {
  Id guid [pk]
  // needs defining - very complicated
}



















