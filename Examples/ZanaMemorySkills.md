# NOTICE

### THESE DO NOT WORK WITH OTHER VERSIONS OF REAGENT.

`PressZanaTempKeys()` is a specific side effect in this fork. This was a quick mockup to explore where all the information is and what could be done.

A better version can (and should) be created that utilizes `OnAreaChange` to check if the skill exists once (since these "skills" cannot be unequipped) and provides additional information like petal count (through UI Panels) and shared cooldown (1s).

## Memory of Desire

Costs 40 petals + 6 petals per Monster Power.

Consumes Petals to cause affected nearby monsters to have a chance to gain bonus rewards and 100% increased Toughness. Higher rarity monsters have a higher chance to gain rewards. The number of Petals consumed is proportional to the Power of affected monsters.  
(7% normal, 15% magic, 100% rare/unique)

Action Type: Multiple Side Effects

```
Skills["ZanaInfluenceMemoryofDesire"].Exists &&
SinceLastActivation(3.0) && (
    MonsterCount(40, MonsterRarity.AtLeastRare) > 0
 || MonsterCount(40, MonsterRarity.Magic) > 3
) ? new ISideEffect[] {
    PressZanaTempKeySideEffect("Desire", Keys.F1, Keys.F2, Keys.F3)
} : null
```

## Memory of Disbelief

Costs 30 petals + 6 petals per Monster Power.

Consumes Petals to cause affected nearby monsters to not be able to drop items that can have rarity. The number of Petals consumed is proportional to the Power of affected monsters.

Action Type: Multiple Side Effects

```
Skills["ZanaInfluenceMemoryofDisbelief"].Exists &&
SinceLastActivation(3.0) && (
    MonsterCount(40, MonsterRarity.AtLeastRare) > 0
 || MonsterCount(40, MonsterRarity.Magic) > 3
) ? new ISideEffect[] {
    PressZanaTempKeySideEffect("Disbelief", Keys.F1, Keys.F2, Keys.F3)
} : null
```

## Memory of Familiarity

Costs 30 petals + 4 petals per Monster Power.

Consumes Petals to cause affected nearby monsters to have either 200% more item quantity or 90% less item quantity, and have all dropped items by of the same type. The number of Petals consumed is proportional to the Power of affected monsters.

Action Type: Multiple Side Effects

```
Skills["ZanaInfluenceMemoryofFamiliarity"].Exists &&
SinceLastActivation(3.0) && (
    MonsterCount(40, MonsterRarity.AtLeastRare) > 0
 || MonsterCount(40, MonsterRarity.Magic) > 3
) ? new ISideEffect[] {
    PressZanaTempKeySideEffect("Familiarity", Keys.F1, Keys.F2, Keys.F3)
} : null
```

## Memory of Impatience

Costs 20 petals + 3 petals per Monster Power.

Consumes Petals to extract Souls from nearby monsters. The number of Petals consumed is proportional to the Power of nearby monsters.

Action Type: Multiple Side Effects

```
Skills["ZanaInfluenceMemoryofImpatience"].Exists &&
SinceLastActivation(3.0) && (
    MonsterCount(40, MonsterRarity.AtLeastRare) > 0
 || MonsterCount(40, MonsterRarity.Magic) > 5
 || MonsterCount(40, MonsterRarity.Normal) > 10
) ? new ISideEffect[] {
    PressZanaTempKeySideEffect("Impatience", Keys.F1, Keys.F2, Keys.F3)
} : null
```

## Memory of Impulsiveness

Costs 30 petals + 4 petals per Monster Power.

Consumes Petals to cause affected nearby monsters to have 200% increased Item Rarity and convert non-unique equipment items to Gold. The number of Petals consumed is proportional to the Power of affected monsters.  
200% increased Quantity of Gold Dropped by Slain Enemies

Action Type: Multiple Side Effects

```
Skills["ZanaInfluenceMemoryofImpulsiveness"].Exists &&
SinceLastActivation(3.0) && (
    MonsterCount(40, MonsterRarity.AtLeastRare) > 0
 || MonsterCount(40, MonsterRarity.Magic) > 3
) ? new ISideEffect[] {
    PressZanaTempKeySideEffect("Impulsiveness", Keys.F1, Keys.F2, Keys.F3)
} : null
```

## Memory of Mocking

Costs 20 petals + 3 petals per Monster Power.

Consumes Petals to gain the modifiers of affected nearby magic and rare monsters for 30 seconds. The number of Petals consumed is proportional to the Power of affected monsters.

Action Type: Multiple Side Effects

```
Skills["ZanaInfluenceMemoryofMocking"].Exists &&
SinceLastActivation(3.0) && (
    MonsterCount(40, MonsterRarity.Rare) > 0
 || MonsterCount(40, MonsterRarity.Magic) > 3
) ? new ISideEffect[] {
    PressZanaTempKeySideEffect("Mocking", Keys.F1, Keys.F2, Keys.F3)
} : null
```

## Memory of Panic

Costs 50 petals + 2 petals per Monster Power.

Consumes Petals to cause affected monsters to revive on death, dropping loot and granting experience again. The number of Petals consumed is proportional to the Power of affected monsters. Does not affect Unique monsters.

Action Type: Multiple Side Effects

```
Skills["ZanaInfluenceMemoryofPanic"].Exists &&
SinceLastActivation(3.0) && (
    MonsterCount(40, MonsterRarity.Rare) > 0
 || MonsterCount(40, MonsterRarity.Magic) > 3
) ? new ISideEffect[] {
    PressZanaTempKeySideEffect("Panic", Keys.F1, Keys.F2, Keys.F3)
} : null
```

## Memory of Suspicion

Costs 30 petals + 0 petals per Monster Power.

Consumes Petals to cause affected nearby normal monsters to have a chance to be upgraded to magic or rare rarity.  
(50% magic, 8% rare)

Action Type: Multiple Side Effects

```
Skills["ZanaInfluenceMemoryofSuspicion"].Exists &&
SinceLastActivation(3.0) && (
    MonsterCount(40, MonsterRarity.Normal) > 10
) ? new ISideEffect[] {
    PressZanaTempKeySideEffect("Suspicion", Keys.F1, Keys.F2, Keys.F3)
} : null
```
