﻿using System.IO;
using Styx;
using Styx.Helpers;

namespace HazzDruid
{
    public class HazzDruidSettings : Settings
    {
        public static readonly HazzDruidSettings Instance = new HazzDruidSettings();

        public HazzDruidSettings()
            : base(Path.Combine(Logging.ApplicationPath, string.Format(@"CustomClasses/HazzDruid/Settings/{0}.xml", StyxWoW.Me.Name)))
        {
        }
        [Setting, DefaultValue(true)]
        public bool UseSurvivalInstincts { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseEnrage { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseBMangle { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseBBeserk { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseMaul { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseThrash { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseDemoralizingRoar { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseSwipe { get; set; }

        [Setting, DefaultValue(true)]
        public bool UsePulverize { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseBFaerieFire { get; set; }

        [Setting, DefaultValue(3)]
        public int LacerateCount { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseBear { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseCat { get; set; }

        [Setting, DefaultValue(4)]
        public int BiteCount { get; set; }

        [Setting, DefaultValue(4)]
        public int RipCount { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseSavageRoar { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseRake { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseShred { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseBerserk { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseFaerieFire { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseSkullBash { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseTigersFury { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseMangle { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseTree { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseRebirth { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseRevive { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseRemoveCurse { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseLifebloom { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseCombat { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseTravel { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseTranquility { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseBarkskin { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseThorns { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseMoTW { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseStarsurge { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseSwarm { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseMoonkin { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseMoonfire { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseStarfall { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseMushroom { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseFoN { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseSolarBeam { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseMoonkinHeal { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseGrasp { get; set; }

        [Setting, DefaultValue(false)]
        public bool UseTyphoon { get; set; }

        [Setting, DefaultValue(true)]
        public bool SpecRestoration { get; set; }

        [Setting, DefaultValue(false)]
        public bool SpecFeral { get; set; }

        [Setting, DefaultValue(false)]
        public bool SpecBalance { get; set; }

        [Setting, DefaultValue(true)]
        public bool UseBSkullBash { get; set; }

        [Setting, DefaultValue(80)]
        public int InnervatePercent { get; set; }

        [Setting, DefaultValue(95)]
        public int SwiftmendPercent { get; set; }

        [Setting, DefaultValue(85)]
        public int RejuvenationPercent { get; set; }

        [Setting, DefaultValue(60)]
        public int RegrowthPercent { get; set; }

        [Setting, DefaultValue(65)]
        public int HealingTouchPercent { get; set; }

        [Setting, DefaultValue(95)]
        public int WildGrowthPercent { get; set; }

        [Setting, DefaultValue(45)]
        public int NaturesPercent { get; set; }

        [Setting, DefaultValue(0)]
        public int ManaPercent { get; set; }

        [Setting, DefaultValue(0)]
        public int HealthPercent { get; set; }

        [Setting, DefaultValue(3)]
        public int MushroomPercent { get; set; }

    }
}