## Hatred

Action Type

```csharp
!Buffs.Has("player_aura_cold_damage") && Skills["Hatred"].Exists && Skills["Hatred"].CanBeUsed
```

## Summon Skitterbots

Action Type: Key

```
!Buffs.Has("skitterbots_buff") && Skills["SummonSkitterbots"].Exists && SinceLastActivation(1.0)
```

## Aura Information

### Red Skill Gems

|Skill Name|Active Skill Name|Buff Name|
|:--|:--|:--|
|Anger|Anger|player_aura_fire_damage|
|Defiance Banner|DefianceBanner||
|Determination|Determination|player_aura_armour|
|Dread Banner|DreadBanner||
|Flesh and Stone (Blood Stance)|FleshAndStone|blood_armour|
|Flesh and Stone (Sand Stance)|FleshAndStone|stone_armour|
|Rejuvenation Totem|RejuvenationTotem|totem_aura_life_regen|
|Vitality|Vitality|player_aura_life_regen|
|Smite|Smite|smite_aura|
|War Banner|WarBanner||

### Green Skill Gems

|Skill Name|Active Skill Name|Buff Name|
|:--|:--|:--|
|Grace|Grace|player_aura_evasion|
|Haste|Haste|player_aura_speed|
|Hatred|Hatred|player_aura_cold_damage|
|Precision|Precision|player_aura_accuracy_and_crits|
|Pride|Pride|player_physical_damage_aura|
|Pride (Self)|Pride|player_physical_damage_aura_self|
|Purity of Ice|PurityOfIce|player_aura_cold_resist|

### Blue Skill Gems

|Skill Name|Active Skill Name|Buff Name|
|:--|:--|:--|
|Arctic Armour|ArcticArmour|new_arctic_armour|
|Automation|Automation|automation|
|Clarity|Clarity|player_aura_mana_regen|
|Discipline|Discipline|player_aura_energy_shield|
|Malevolence|Malevolence|player_aura_damage_over_time|
|Purity of Elements|PurityOfElements|player_aura_resists|
|Purity of Fire|PurityOfFire|player_aura_fire_resist|
|Purity of Lightning|PurityOfLightning|player_aura_lightning_resist|
|Summon Chaos Golem|SummonChaosGolem|chaos_elemental_buff|
|Summon Lightning Golem|SummonLightningGolem|lightning_elemental_buff|
|Summon Skitterbots|SummonSkitterbots|skitterbots_buff|
|Wrath|Wrath|player_aura_lightning_damage|
|Zealotry|Zealotry|player_aura_spell_damage|