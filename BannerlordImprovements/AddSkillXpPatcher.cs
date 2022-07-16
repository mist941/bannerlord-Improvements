
using HarmonyLib;
using System.Xml;
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
            XmlNode xmlNode = MySubModule.config.config.ChildNodes[1].SelectSingleNode("MultiplierSettings");
            float factor = float.Parse(xmlNode.SelectSingleNode("MultiplierFactor").InnerText);
            float newXpAmount = xpAmount * factor;
            hero.HeroDeveloper.AddSkillXp(skill, newXpAmount, true, true);
        }
    }
}
