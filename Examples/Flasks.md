## Dual Soul Catchers

For legacy permanent vaal builds.

Action Type: Multiple Side Effects

```csharp
SinceLastActivation(0.1) &&
Monsters(100).Any() &&
!Flasks[0].Active &&
!Flasks[4].Active &&
Flasks[0].Charges >= 30

? new ISideEffect[]{PressKeySideEffect("Q")}
:

SinceLastActivation(0.1) &&
Monsters(100).Any() &&
!Flasks[0].Active &&
!Flasks[4].Active &&
Flasks[4].Charges >= 30

? new ISideEffect[]{PressKeySideEffect("W")}
: null
```
