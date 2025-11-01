## Individual HP Flask

Action Type: Key

```csharp
SinceLastActivation(0.5) &&
Flasks[0].CanBeUsed &&
!Flasks[0].Active &&
Vitals.HP.Percent <= 60
```

## Individual Mana Flask

Action Type: Key

```csharp
SinceLastActivation(0.5) &&
Flasks[3].CanBeUsed &&
!Flasks[3].Active &&
Vitals.Mana.Percent <= 15
```

## Individual Quicksilver Flask

Action Type: Key

```csharp
SinceLastActivation(0.5) &&
IsMoving &&
!Flasks[2].Active &&
Flasks[2].CanBeUsed
```

## Group of HP flasks

Action Type: Multiple Side Effects

```csharp
SinceLastActivation(0.5) &&
!Flasks[3].Active &&
!Flasks[4].Active &&
Vitals.HP.Percent <= 60 
? Flasks[0].CanBeUsed ? PressKeySideEffect(Keys.D1)
                      : Flasks[1].CanBeUsed ? PressKeySideEffect(Keys.D2)
                                            : null
: null
```

## Dual Soul Catchers

For legacy permanent vaal builds.

Action Type: Multiple Side Effects

```csharp
SinceLastActivation(0.1) &&
Monsters(100).Any() &&
!Flasks[0].Active &&
!Flasks[4].Active &&
Flasks[0].Charges >= 30

? new ISideEffect[]{PressKeySideEffect(Keys.Q)}
:

SinceLastActivation(0.1) &&
Monsters(100).Any() &&
!Flasks[0].Active &&
!Flasks[4].Active &&
Flasks[4].Charges >= 30

? new ISideEffect[]{PressKeySideEffect(Keys.W)}
: null
```

