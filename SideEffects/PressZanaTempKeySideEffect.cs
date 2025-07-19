using ExileCore.PoEMemory.Components;
using ExileCore.Shared.Enums;
using ReAgent.State;
using System.Linq;
using System.Linq.Dynamic.Core.CustomTypeProviders;
using System.Windows.Forms;
using SharpDX;
using static ExileCore.Shared.Nodes.HotkeyNodeV2;
using static System.Net.Mime.MediaTypeNames;

namespace ReAgent.SideEffects;

[DynamicLinqType]
[Api]
public record PressZanaTempKeySideEffect(string ShortName, HotkeyNodeValue Key0, HotkeyNodeValue Key1, HotkeyNodeValue Key2) : ISideEffect
{
    public PressZanaTempKeySideEffect(string shortName, Keys key0, Keys key1, Keys key2) : this(shortName, new HotkeyNodeValue(key0), new HotkeyNodeValue(key1), new HotkeyNodeValue(key2))
    {
    }

    public SideEffectApplicationResult Apply(RuleState state)
    {
        var zanaSkill = state.GameController.Player.GetComponent<Actor>().ActorSkills
            .FirstOrDefault(skill => skill.Name.StartsWith("Zana") && skill.Name.EndsWith(ShortName));

        if (zanaSkill == null)
        {
            return SideEffectApplicationResult.UnableToApply;
        }

        var zanaSkillKey = zanaSkill.Stats.TryGetValue(GameStat.ZanaSkillIndex, out var index) ? index switch
        {
            1 => Key1,
            2 => Key2,
            _ => Key0
        } : Key0;

        if (!state.InternalState.CanPressKey)
        {
            return SideEffectApplicationResult.UnableToApply;
        }

        if (state.InternalState.KeyToPress == zanaSkillKey)
        {
            return SideEffectApplicationResult.AppliedDuplicate;
        }

        if (state.InternalState.KeyToPress != null)
        {
            return SideEffectApplicationResult.UnableToApply;
        }

        state.InternalState.KeyToPress = zanaSkillKey;
        return SideEffectApplicationResult.AppliedUnique;
    }

    public override string ToString() => $"Press Zana Temp Key \"{ShortName}\" [{Key0}, {Key1}, {Key2}]";
}