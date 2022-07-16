
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace BannerlordImprovements.Patches
{
    [HarmonyPatch(typeof(Hero), "AddSkillXp")]
    public class AddSkillXpPatcher
    {
        private static void Prefix(Hero __instance, SkillObject skill, float xpAmount)
        {
            Hero hero = __instance;
            float newXpAmount = xpAmount * 20;
            hero.HeroDeveloper.AddSkillXp(skill, newXpAmount, true, true);
        }
    }
}
