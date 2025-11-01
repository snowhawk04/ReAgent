## Blood Rage

Action Type: Key

```csharp
SinceLastActivation(0.5) &&
Skills["BloodRage"].CanBeUsed &&
!Buffs.Has("blood_rage") &&
Vitals.HP.Percent >= 90
```

## Call of Steel

Action Type: Key

```csharp
SinceLastActivation(0.5) &&
Skills["CallOfSteel"].CanBeUsed &&
!Buffs.Has("steel_skill_ammo_buff")
```

## Warcries

Warcries are enhanced proportionately to the power of nearby enemies, calculated at the time they are used. Normal monsters count as 1 power, magic monsters as 2, rare as 10, unique as 20, and players as 5.

The following warcries count power differently:

* Rallying Cry gains power based on nearby allies and enemies
* General's Cry gains power based on nearby enemies and enemy corpses

Action Type: Key

```csharp
Skills["EnduringCry"].Exists &&
SinceLastActivation(6.0) && (
    MonsterCount(40, MonsterRarity.AtLeastRare) > 0
 || MonsterCount(40, MonsterRarity.Magic) > 2
 || MonsterCount(40, MonsterRarity.Normal) > 4
)
```

## Plague Bearer

Action Type: Key

```csharp
SinceLastActivation(1.1) &&
Monsters(1).Any() &&
(
    !Buffs.Has("corrosive_shroud_buff") ||
    !Buffs.Has("corrosive_shroud_at_max_damage")
)
```

Note: A better version would also toggle off plague bearer when no monsters are around.

## Withering Step

Action Type: Key

```csharp
Skills["WitheringStep"].Exists &&
SinceLastActivation(3.0) &&
Skills["WitheringStep"].CanBeUsed &&
MonsterCount(20, MonsterRarity.AtLeastRare) > 0
```
