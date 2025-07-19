## Sentinel of Radiance (Sentinel Mechanic)

### Progress Bar

Action Type: Multiple Side Effects

```csharp
SinceLastActivation(3) &&
Skills["SummonSentinelOfRadiance"].CanBeUsed &&
FriendlyMonsters.Where(p => p.Path.Contains("Axis")).Count() < 1 && 
( MonsterCount(100, MonsterRarity.AtLeastRare) >= 1 || MonsterCount(100, MonsterRarity.Any) >= 10 )

? new ISideEffect[] { 
PressKeySideEffect("W"),
ResetTimerSideEffect("Sentinel"),
StartTimerSideEffect("Sentinel"),

}
: 
 GetTimerValue("Sentinel") > 1
? new ISideEffect[] { 

StartTimerSideEffect("Sentinel"), 
ProgressBarSideEffect("Sentinel:            ", new Vector2(65 as x, 163 as y), new Vector2(20 as barx,15f as bary), (20 - GetTimerValue("Sentinel")), "darkred", "black", "white"),
} 
: null
```

### Timer Update

```csharp
20 - GetTimerValue("Sentinel")  < 0

? new ISideEffect[] { 
ResetTimerSideEffect("Sentinel")
}
: null
```