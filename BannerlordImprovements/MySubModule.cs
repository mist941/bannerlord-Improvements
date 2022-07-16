using HarmonyLib;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BannerlordImprovements
{
    public class MySubModule: MBSubModuleBase
    {
        public static BannerlordImprovementsConfig config = new BannerlordImprovementsConfig();
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);
            var campaign = game.GameType as Campaign;
            if (campaign == null)
            {
                return;
            }
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            try
            {
                new Harmony("mod.bannerlord.bannerlordimprovements").PatchAll();
            }
            catch (Exception ex)
            {
                InformationManager.DisplayMessage(new InformationMessage(ex.ToString()));
            }
        }
    }
}

//bannerlordimprovements