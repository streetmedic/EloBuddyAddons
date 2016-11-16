﻿using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using System.Linq;
using System.Collections.Generic;
using SharpDX;

namespace UnsignedEvade
{
    static class SpellDatabase
    {
        public static List<SpellInfo> SpellList = new List<SpellInfo>();

        #region Existing Spell List
        static List<SpellInfo> SpellInfoList = new List<SpellInfo>()
        {
            #region AllChampions
            //Ludens Echo
            new SpellInfo()
            {
                MissileName = "ItemMagicShankMis",
                MissileSpeed = 1400f,
                MissileMinSpeed = 1400f,
                MissileMaxSpeed = 1400f,
                Range = 725f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Tiamat
            new SpellInfo()
            {
                SpellName = "ItemTiamatCleave",
                Range = 325f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Protobelt
            new SpellInfo()
            {
                SpellName = "ItemSoFBoltSpellBase",
                MissileName = "ItemSoFBoltSpellMissile",
                Range = 850f,
                MissileSpeed = 1600f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                Width = 75f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                DashType = SpellInfo.Dashtype.Linear,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Edge of Night
            new SpellInfo()
            {
                SpellName = "ItemVeilChannel",
                Range = 500f,
                MissileSpeed = 828.5f,
                MissileMinSpeed = 2.079758E-34f,
                MissileMaxSpeed = 0f,
                Width = 0f,
                Radius = 500f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //BOTRK
            new SpellInfo()
            {
                SpellName = "ItemSwordOfFeastAndFamine",
                MissileName = "ItemSwordOfFeastAndFamineTransfuse",
                MissileSpeed = 1200f,
                MissileMinSpeed = 1200f,
                MissileMaxSpeed = 1200f,
                Range = 550f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
            },
            //Seraphs Embrace Shield
            new SpellInfo()
            {
                SpellName = "ItemSeraphsEmbrace",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Pink Vision Item to give enemies of invis traps on acensions
            new SpellInfo()
            {
                SpellName = "OracleExtractSight",
                Range = 400f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Zhonyas 
            new SpellInfo()
            {
                SpellName = "ZhonyasHourglass",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Zhonyas
            new SpellInfo()
            {
                SpellName = "BilgewaterCutlass",
                Range = 550f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
            },
            //BOTRK
            new SpellInfo()
            {
                SpellName = "RanduinsOmen",
                Range = 500f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Slow,
            },
            //Redemption
            new SpellInfo()
            {
                SpellName = "ItemRedemption",
                Range = 5500f,//not sure on this. have to actually use the item to test
                Radius = 550f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //recall
            new SpellInfo()
            {
                SpellName = "recall",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Teleport
            new SpellInfo()
            {
                SpellName = "SummonerTeleport",
                Range = int.MaxValue,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Smite
            new SpellInfo()
            {
                SpellName = "SummonerSmite",
                Range = 500f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Flash
            new SpellInfo()
            {
                SpellName = "SummonerFlash",
                Range = 425,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                DashType = SpellInfo.Dashtype.Blink,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Ignite
            new SpellInfo()
            {
                SpellName = "SummonerDot",
                Range = 600,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Heal
            new SpellInfo()
            {
                SpellName = "SummonerHeal",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Exhaust
            new SpellInfo()
            {
                SpellName = "SummonerExhaust",
                Range = 650f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Heal
            new SpellInfo()
            {
                SpellName = "SummonerBoost",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Youmuus
            new SpellInfo()
            {
                SpellName = "YoumusBlade",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Ghost
            new SpellInfo()
            {
                SpellName = "SummonerHaste",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Barrier
            new SpellInfo()
            {
                SpellName = "SummonerBarrier",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Blue Buff something?
            new SpellInfo()
            {
                MissileName = "CrestOfTheAncientGolemLines",
                MissileSpeed = 2200f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                Range = 1200f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
            },
            //Hextech GLP
            new SpellInfo()
            {
                MissileName = "ItemWillBoltSpellMissile",
                MissileSpeed = 4000f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 4000f,
                Range = 1000f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
            },
            #endregion
            #region Aatrox
            //q
            new SpellInfo()
            {
                SpellName = "AatroxQ",
                ChampionName = "Aatrox",
                Range = 650f,
                canVaryInLength = true,
                Width = 0f,
                Radius = 285f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "AatroxW",
                ChampionName = "Aatrox",
                Range = 1f,
                MissileSpeed = 0f,
                MissileMinSpeed = 6.308672E-34f,
                MissileMaxSpeed = 0f,
                Width = 0f,
                Radius = 100f,
                ConeDegrees = 45f,
                OtherMissileNames = new string[] { "AatroxW2" },
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                /*ChampionName = "Aatrox",
                Range = 1050f,
                MissileSpeed = 1200f,
                MissileMinSpeed = 1200f,
                MissileMaxSpeed = 1200f,
                Width = 15f,
                ConeDegrees = 45f,
                OtherMissileNames = new string[] { "AatroxEConeMissile", "AatroxEConeMissile2" },
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,*/
            },
            //r
            new SpellInfo()
            {
                SpellName = "AatroxR",
                MissileName = "AatroxRHeal",
                ChampionName = "Aatrox",
                Radius = 550f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Ahri
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Charm,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r (bolts, not he dash itself)
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Akali
            //q
            new SpellInfo()
            {
                SpellName = "AkaliMota",
                ChampionName = "Akali",
                Range = 600f,
                MissileSpeed = 1000f,
                MissileMinSpeed = 1000f,
                MissileMaxSpeed = 1000f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "AkaliSmokeBomb",
                ChampionName = "Akali",
                Range = 700f,
                MissileSpeed = 0f,
                MissileMinSpeed = 0f,
                MissileMaxSpeed = 0f,
                Width = 0f,
                Radius = 390f,
                ConeDegrees = 45f,
                Delay = 8.25f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "AkaliShadowSwipe",
                ChampionName = "Akali",
                MissileSpeed = 0f,
                MissileMinSpeed = 0f,
                MissileMaxSpeed = 0f,
                Radius = 325f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "AkaliShadowDance",
                ChampionName = "Akali",
                Range = 400f,
                MissileSpeed = 2200f,
                MissileMinSpeed = 2200f,
                MissileMaxSpeed = 2200f,
                Radius = 300f,
                ConeDegrees = 45f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Alistar
            //q
            new SpellInfo()
            {
                SpellName = "Pulverize",
                ChampionName = "Alistar",
                Range = 365f,
                Radius = 365f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "Headbutt",
                ChampionName = "Alistar",
                Range = 650f,
                MissileSpeed = 0f,
                MissileMinSpeed = 0f,
                MissileMaxSpeed = 0f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "AlistarE",
                ChampionName = "Alistar",
                Range = 350f,
                Radius = 575f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "FerociousHowl",
                ChampionName = "Alistar",
                Delay = 7.25f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Amumu
            //q
            new SpellInfo()
            {
                SpellName = "BandageToss",
                MissileName = "SadMummyBandageToss",
                ChampionName = "Amumu",
                Range = 1100f,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 80f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "AuraofDespair",
                BuffName = "AuraofDespair",
                ChampionName = "Amumu",
                Range = 300f,
                Radius = 300f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "Tantrum",
                ChampionName = "Amumu",
                Range = 350f,
                Radius = 350f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "CurseoftheSadMummy",
                ChampionName = "Amumu",
                Range = 550f,
                Radius = 550f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Entangle,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Anivia
            //q
            new SpellInfo()
            {
                SpellName = "FlashFrost",
                ChampionName = "Anivia",
                MissileName = "FlashFrostSpell",
                MissileSpeed = 850f,
                MissileMinSpeed = 850f,
                MissileMaxSpeed = 850f,
                Range = 1100f,
                Width = 110f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w Handled Under Particle Database
            new SpellInfo()
            {
                SpellName = "Crystallize",
                ChampionName = "Anivia",
                Range = 1000f,
                MissileSpeed = 1600f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                Width = 0f,
                Radius = 100f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.Wall,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "Frostbite",
                MissileName = "Frostbite",
                ChampionName = "Anivia",
                Range = 600f,
                MissileSpeed = 1600f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r Handled under Particle Darabase
            new SpellInfo()
            {
                //SpellName = "GlacialStorm",
                ChampionName = "Anivia",
                Range = 750f,
                Width = 150f,
                Radius = 200f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Annie
            //aa
            new SpellInfo()
            {
                MissileName = "AnnieBasicAttack",
                ChampionName = "Annie",
                MissileSpeed = 1200f,
                MissileMinSpeed = 1200f,
                MissileMaxSpeed = 1200f,
                Range = 665f,
                OtherMissileNames = new string[] { "AnnieBasicAttack2" },
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //q
            new SpellInfo()
            {
                SpellName = "Disintegrate",
                MissileName = "Disintegrate",
                ChampionName = "Annie",
                MissileSpeed = 1400f,
                MissileMinSpeed = 1400f,
                MissileMaxSpeed = 1400f,
                Range = 625f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "Incinerate",
                ChampionName = "Annie",
                Range = 600f,
                MissileSpeed = 0f,
                MissileMinSpeed = 0f,
                MissileMaxSpeed = 0f,
                ConeDegrees = 24.76f,
                Width = 0f,
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "InfernalGuardian",
                ChampionName = "Annie",
                Range = 600f,
                MissileSpeed = 0f,
                MissileMinSpeed = 0f,
                MissileMaxSpeed = 0f,
                Radius = 250.3f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //add ashe basic attack having a slow
            #region Ashe
            //q
            new SpellInfo()
            {
                SpellName = "AsheQ",
                ChampionName = "Ashe",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "Volley",
                MissileName = "VolleyAttack",
                ChampionName = "Ashe",
                Range = 1150f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Width = 20f,
                Radius = 100f,
                ConeDegrees = 20f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "AsheSpiritOfTheHawk",
                MissileName = "AsheSpiritOfTheHawk",
                ChampionName = "Ashe",
                Range = int.MaxValue,
                MissileSpeed = 1400f,
                MissileMinSpeed = 1400f,
                MissileMaxSpeed = 1400f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "EnchantedCrystalArrow",
                MissileName = "EnchantedCrystalArrow",
                ChampionName = "Ashe",
                Range = int.MaxValue,
                MissileSpeed = 1600f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                Width = 130f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Aurelion Sol
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Azir
            //q
            new SpellInfo()
            {
                SpellName = "AzirQ",
                ChampionName = "Azir",
                Range = 875f,
                MissileSpeed = 500f,
                MissileMinSpeed = 2.305022E-38f,
                MissileMaxSpeed = 0f,
                Width = 0f,
                Radius = 0f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "AzirW",
                ChampionName = "Azir",
                Range = 450f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "AzirE",
                ChampionName = "Azir",
                Range = 1100f,
                MissileSpeed = 500f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "AzirR",
                ChampionName = "Azir",
                Range = 250f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                SpellType = SpellInfo.SpellTypeInfo.MovingWall,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Bard
            //q
            new SpellInfo()
            {
                SpellName = "BardQ",
                ChampionName = "Bard",
                Range = 950f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Width = 60f,
                OtherMissileNames = new string[] { "BardQMissile2" },
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w on champion
            new SpellInfo()
            {
                SpellName = "BardWDirectHeal",
                ChampionName = "Bard",
                Range = 800f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w on ground
            new SpellInfo()
            {
                SpellName = "BardW",
                ChampionName = "Bard",
                Range = 800f,
                Radius = 100f,
                OtherMissileNames = new string[] { "BardWHealthPack", },
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e Not sure how to handle this
            new SpellInfo()
            {
                SpellName = "BardE",
                ChampionName = "Bard",
                //Range = 900f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "BardR",
                ChampionName = "Bard",
                Range = 3400f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Radius = 350f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Statis,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Blitzcrank
            //q
            new SpellInfo()
            {
                SpellName = "RocketGrab",
                ChampionName = "Blitzcrank",
                MissileName = "RocketGrabMissile",
                MissileSpeed = 1800f,
                MissileMinSpeed = 1800f,
                MissileMaxSpeed = 1800f,
                Range = 1050f,
                Width = 70f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Pull,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "Overdrive",
                ChampionName = "Blitzcrank",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "PowerFist",
                ChampionName = "Blitzcrank",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "StaticField",
                ChampionName = "Blitzcrank",
                Range = 600f,
                MissileSpeed = 347.8f,
                MissileMinSpeed = 347.8f,
                MissileMaxSpeed = 347.8f,
                Width = 0f,
                Radius = 600f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Silence,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //add brand passive
            #region Brand
            //q
            new SpellInfo()
            {
                SpellName = "BrandQ",
                MissileName = "BrandQMissile",
                ChampionName = "Brand",
                MissileSpeed = 1600f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Range = 1100f,
                Width = 60f,
                CollisionCount = 1,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "BrandW",
                ChampionName = "Brand",
                Range = 900f,
                Width = 0f,
                Radius = 240f,
                Delay = 0.875f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "BrandE",
                ChampionName = "Brand",
                Range = 675f,
                MissileSpeed = 1800f,
                MissileMinSpeed = 1400f,
                MissileMaxSpeed = 1400f,
                Width = 0f,
                Radius = 710f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "BrandR",
                MissileName = "BrandRMissile",
                ChampionName = "Brand",
                Range = 750f,
                MissileSpeed = 750f,
                MissileMinSpeed = 250f,
                MissileMaxSpeed = 3000f,
                Width = 0f,
                Radius = 0f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
                OtherMissileNames = new string[] { "BrandR" },
            },
            #endregion
            //add braum aa passive stun
            #region Braum
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Caitlyn
            //aa
            new SpellInfo()
            {
                MissileName = "CaitlynBasicAttack",
                ChampionName = "Caitlyn",
                Range = 750f,
                MissileSpeed = 2500f,
                MissileMinSpeed = 2500f,
                MissileMaxSpeed = 2500f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //headshot
            new SpellInfo()
            {
                MissileName = "CaitlynHeadshotMissile",
                ChampionName = "Caitlyn",
                MissileSpeed = 3000f,
                MissileMinSpeed = 2500f,
                MissileMaxSpeed = 2500f,
                Range = 750f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //q
            new SpellInfo()
            {
                SpellName = "CaitlynPiltoverPeacemaker",
                MissileName = "CaitlynPiltoverPeacemaker",
                ChampionName = "Caitlyn",
                Range = 1300f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q2
            new SpellInfo()
            {
                SpellName = "CaitlynPiltoverPeacemaker",
                MissileName = "CaitlynPiltoverPeacemaker2",
                ChampionName = "Caitlyn",
                Range = 1300f,
                Width = 90f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "CaitlynYordleTrap",
                ChampionName = "Caitlyn",
                Range = 800f,
                MissileSpeed = 1450f,
                MissileMinSpeed = 1450f,
                MissileMaxSpeed = 1450f,
                Width = 0f,
                Radius = 75f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "CaitlynEntrapment",
                MissileName = "CaitlynEntrapmentMissile",
                ChampionName = "Caitlyn",
                Range = 800f,
                MissileSpeed = 1600f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 70f,
                Radius = 20f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "CaitlynAceintheHole",
                MissileName = "CaitlynAceintheHoleMissile",
                ChampionName = "Caitlyn",
                Range = 2000f,
                MissileSpeed = 3200f,
                MissileMinSpeed = 2200f,
                MissileMaxSpeed = 2200f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Cassiopeia
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Ground,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region ChoGath
            //q
            new SpellInfo()
            {
                SpellName = "Rupture",
                ChampionName = "Chogath",
                Range = 950f,
                Radius = 250f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "FeralScream",
                ChampionName = "Chogath",
                Range = 300f,
                ConeDegrees = 28f,
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.Silence,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                MissileName = "VorpalSpikesMissle",
                ChampionName = "Chogath",
                MissileSpeed = 1475f,
                MissileMinSpeed = 1475f,
                MissileMaxSpeed = 1475f,
                Range = 650f,
                Width = 170f,//190. scales with size
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
                OtherMissileNames = new string[] { "VorpalSpikesMissle2", "VorpalSpikesMissle3","VorpalSpikesMissle4","VorpalSpikesMissle5","VorpalSpikesMissle6","VorpalSpikesMissle7","VorpalSpikesMissle8",},
            },
            //r
            new SpellInfo()
            {
                SpellName = "Feast",
                ChampionName = "Chogath",
                Range = 175f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Corki
            //aa
            new SpellInfo()
            {
                MissileName = "CorkiBasicAttack",
                ChampionName = "Corki",
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Range = 650f,
                SpellType = SpellInfo.SpellTypeInfo.None,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
                OtherMissileNames = new string[] { "CorkiBasicAttack2" },
            },
            //q
            new SpellInfo()
            {
                SpellName = "PhosphorusBomb",
                MissileName = "PhosphorusBombMissile",
                ChampionName = "Corki",
                Range = 825f,
                MissileSpeed = 1000f,
                MissileMinSpeed = 1000f,
                MissileMaxSpeed = 1000f,
                Radius = 250f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
                OtherMissileNames = new string[] { "PhosphorusBombMissileMin" },
            },
            //w
            new SpellInfo()
            {
                SpellName = "CarpetBomb",
                ChampionName = "Corki",
                BuffName = "GGun",
                Range = 600f,
                MissileSpeed = 700f,
                MissileMinSpeed = 700f,
                MissileMaxSpeed = 700f,
                Width = 200f,
                Radius = 100f,
                ConeDegrees = 45f,
                canVaryInLength = true,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            
            //w2
            new SpellInfo()
            {
                SpellName = "CarpetBombMega",
                ChampionName = "Corki",
                Range = 1800f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Width = 200f,
                canVaryInLength = true,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w
            new SpellInfo()
            {
                SpellName = "CarpetBomb2",
                ChampionName = "Corki",
                Range = 600f,
                MissileSpeed = 700f,
                MissileMinSpeed = 700f,
                MissileMaxSpeed = 700f,
                Width = 200f,
                Radius = 100f,
                ConeDegrees = 45f,
                //2 seconds for fire to stay
                Delay = 2.25f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            
            //w2
            new SpellInfo()
            {
                SpellName = "CarpetBombMega2",
                ChampionName = "Corki",
                Range = 1800f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Width = 200f,
                //5 seconds for fire to stay
                Delay = 5.25f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "GGun",
                ChampionName = "Corki",
                BuffName = "GGun",
                Range = 600f,
                MissileSpeed = 902f,
                MissileMinSpeed = 902f,
                MissileMaxSpeed = 902f,
                Width = 0f,
                Radius = 100f,
                ConeDegrees = 28f,
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "MissileBarrageMissile",
                MissileName = "MissileBarrageMissile",
                ChampionName = "Corki",
                Range = 1300f,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 40f,
                Radius = 299.3f,
                ConeDegrees = 45f,
                CollisionCount = 1,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
                OtherMissileNames = new string[] { "MissileBarrage" }
            },
            //r2
            new SpellInfo()
            {
                SpellName = "MissileBarrageMissile2",
                MissileName = "MissileBarrageMissile2",
                ChampionName = "Corki",
                Range = 1500f,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 40f,
                CollisionCount = 1,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },

            #endregion
            //add darius Q/W
            #region Darius
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "DariusAxeGrabCone",
                ChampionName = "Darius",
                Range = 550f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Radius = 225f,
                ConeDegrees = 25f,
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.Pull,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "DariusExecute",
                ChampionName = "Darius",
                Range = 475f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Diana
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ArcSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Pull,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region DrMundo
            //q
            new SpellInfo()
            {
                SpellName = "InfectedCleaverMissile",
                MissileName = "InfectedCleaverMissile",
                ChampionName = "DrMundo",
                Range = 1050f,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "BurningAgony",
                ChampionName = "DrMundo",
                BuffName = "BurningAgony",
                Radius = 325f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "Masochism",
                ChampionName = "DrMundo",
                Range = 300f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "Sadism",
                ChampionName = "DrMundo",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Draven
            //q
            new SpellInfo()
            {
                SpellName = "DravenSpinning",
                ChampionName = "Draven",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "DravenFury",
                ChampionName = "Draven",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "DravenDoubleShot",
                MissileName = "DravenDoubleShotMissile",
                ChampionName = "Draven",
                Range = 1400f,
                MissileSpeed = 1400f,
                MissileMinSpeed = 1400f,
                MissileMaxSpeed = 1400f,
                Width = 130f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "DravenRCast",
                MissileName = "DravenR",
                ChampionName = "Draven",
                Range = int.MaxValue,
                canVaryInLength = true,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 160f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion  
            #region Ekko
            //q
            new SpellInfo()
            {
                SpellName = "EkkoQ",
                MissileName = "EkkoQMis",
                ChampionName = "Ekko",
                Range = 1075f,
                MissileSpeed = 1650f,
                MissileMinSpeed = 1650f,
                MissileMaxSpeed = 1650f,
                Width = 60f,
                OtherMissileNames = new string[] { "EkkoQReturn", "EkkoQReturnDead" },
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "EkkoW",
                ChampionName = "Ekko",
                MissileName = "EkkoWMis",
                Range = 1600f,
                MissileSpeed = 1500f,
                Radius = 400f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e first dash
            new SpellInfo()
            {
                SpellName = "EkkoE",
                ChampionName = "Ekko",
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e dash 2
            new SpellInfo()
            {
                SpellName = "EkkoEAttack",
                ChampionName = "Ekko",
                DashType = SpellInfo.Dashtype.Blink,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "EkkoR",
                ChampionName = "Ekko",
                Range = int.MaxValue,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Radius = 375f,
                DashType = SpellInfo.Dashtype.Blink,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Elise
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q spider
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w spider
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e spider
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Evelynn
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Ezreal
            //q
            new SpellInfo()
            {
                SpellName = "EzrealMysticShot",
                MissileName = "EzrealMysticShotMissile",
                ChampionName = "Ezreal",
                Range = 1200f,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 80f,//or 60
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "EzrealEssenceFluxMissile",
                MissileName = "EzrealEssenceFluxMissile",
                ChampionName = "Ezreal",
                Range = 1050f,
                MissileSpeed = 1600f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                Width = 80f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "EzrealArcaneShift",
                MissileName = "EzrealArcaneShiftMissile",
                ChampionName = "Ezreal",
                Range = 475f,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                DashType = SpellInfo.Dashtype.Blink,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "EzrealTrueshotBarrage",
                MissileName = "EzrealTrueshotBarrage",
                ChampionName = "Ezreal",
                Range = int.MaxValue,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 160f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Fiddlesticks
            //q
            new SpellInfo()
            {
                SpellName = "Terrify",
                ChampionName = "FiddleSticks",
                Range = 525f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Fear,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "Drain",
                ChampionName = "FiddleSticks",
                Range = 575f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w channel
            new SpellInfo()
            {
                SpellName = "DrainChannel",
                ChampionName = "FiddleSticks",
                Range = 650f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "FiddlesticksDarkWind",
                MissileName = "FiddlesticksDarkWind",
                ChampionName = "FiddleSticks",
                Range = 750f,
                MissileSpeed = 1100f,
                MissileMinSpeed = 1100f,
                MissileMaxSpeed = 1100f,
                OtherMissileNames = new string[] { "FiddleSticksDarkWindMissile", },
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Silence,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //do fiora w cc calculations
            #region Fiora
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Fizz
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Galio
            //q
            new SpellInfo()
            {
                SpellName = "GalioResoluteSmite",
                MissileName = "GalioResoluteSmite",
                ChampionName = "Galio",
                Range = 900f,
                MissileSpeed = 1300f,
                MissileMinSpeed = 1300f,
                MissileMaxSpeed = 1300f,
                Width = 120f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "GalioBulwark",
                ChampionName = "Galio",
                Range = 800f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "GalioRighteousGust",
                ChampionName = "Galio",
                Range = 1180f,
                MissileSpeed = 1f,
                MissileMinSpeed = 1f,
                MissileMaxSpeed = 1f,
                Delay = 5.25f,
                Width = 120f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "GalioIdolOfDurand",
                ChampionName = "Galio",
                Radius = 550f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Taunt,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Gangplank
            //q
            new SpellInfo()
            {
                SpellName = "GangplankQWrapper",
                MissileName = "GangplankQProceed",
                ChampionName = "Gangplank",
                Range = 625f,
                MissileSpeed = 2600f,
                MissileMinSpeed = 2600f,
                MissileMaxSpeed = 2600f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
                OtherMissileNames = new string[] { "GangplankQProceed" },
            },
            //w
            new SpellInfo()
            {
                SpellName = "GangplankW",
                ChampionName = "Gangplank",
                Range = 400f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Width = 0f,
                Radius = 0f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e in Trap Database
            /*new SpellInfo()
            {
                SpellName = "GangplankE",
                ChampionName = "Gangplank",
                Range = 1000f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Width = 0f,
                Radius = 325f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },*/
            //r
            new SpellInfo()
            {
                SpellName = "GangplankR",
                ChampionName = "Gangplank",
                Range = 30000f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Width = 0f,
                Radius = 525f,
                ConeDegrees = 45f,
                Delay = 7.25f,
                TravelTime = 0,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Garen
            //q charge
            new SpellInfo()
            {
                SpellName = "GarenQ",
                ChampionName = "Garen",
                Range = 300f,
                MissileSpeed = 0f,
                MissileMinSpeed = 3.09577E-35f,
                MissileMaxSpeed = 0f,
                Width = 0f,
                Radius = 210f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q attack
            new SpellInfo()
            {
                SpellName = "GarenQAttack",
                ChampionName = "Garen",
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Silence,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "GarenW",
                ChampionName = "Garen",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "GarenE",
                ChampionName = "Garen",
                Range = 660f,
                Radius = 660f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Gnar
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q form
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w form
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e form
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Gragas
            //q
            new SpellInfo()
            {
                SpellName = "GragasQ",
                MissileName = "GragasQMissile",
                ChampionName = "Gragas",
                Range = 1100f,
                MissileSpeed = 800f,
                MissileMinSpeed = 800f,
                MissileMaxSpeed = 800f,
                Width = 110f,
                Radius = 250f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "GragasWAttack",
                ChampionName = "Gragas",
                Range = 400f,
                MissileSpeed = 828.5f,
                MissileMinSpeed = 828.5f,
                MissileMaxSpeed = 828.5f,
                Width = 0f,
                Radius = 210f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "GragasE",
                ChampionName = "Gragas",
                Range = 600f,
                MissileSpeed = 900f,
                MissileMinSpeed = 900f,
                MissileMaxSpeed = 900f,
                Width = 200f,
                Radius = 200f,
                CollisionCount = 1,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "GragasR",
                ChampionName = "Gragas",
                MissileName = "GragasRBoom",
                TravelTime = 0.55f,
                MissileSpeed = 1800f,
                MissileMinSpeed = 1800f,
                MissileMaxSpeed = 1800f,
                Range = 1050f,
                Width = 120f,
                Radius = 350f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //add graves auto
            #region Graves
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Nearsight,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            //r cone split
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Hecarim
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Fear,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //add turret empowered hits
            #region Heimerdinger
            //turret attacks
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Illaoi
            //q
            new SpellInfo()
            {
                SpellName = "IllaoiQ",
                ChampionName = "Illaoi",
                Range = 800f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Delay = 0.75f,
                Width = 250f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "IllaoiW",
                ChampionName = "Illaoi",
                Range = 350f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "IllaoiE",
                ChampionName = "Illaoi",
                MissileName = "IllaoiEMis",
                MissileSpeed = 1900f,
                MissileMinSpeed = 1900f,
                MissileMaxSpeed = 1900f,
                Range = 950f,
                Width = 50f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "IllaoiR",
                ChampionName = "Illaoi",
                Radius = 450f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Irelia
            //q
            new SpellInfo()
            {
                SpellName = "IreliaGatotsu",
                ChampionName = "Irelia",
                Range = 650f,
                MissileSpeed = 2200f,
                MissileMinSpeed = 2200f,
                MissileMaxSpeed = 2200f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "IreliaHitenStyle",
                ChampionName = "Irelia",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.Nearsight,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "IreliaEquilibriumStrike",
                ChampionName = "Irelia",
                Range = 425f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "IreliaTranscendentBlades",
                MissileName = "IreliaTranscendentBladesSpell",
                ChampionName = "Irelia",
                Range = 1200f,
                MissileSpeed = 1600f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                Width = 120f,
                Radius = 1200f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Ivern
            //q
            new SpellInfo()
            {
                SpellName = "IvernQ",
                MissileName = "IvernQ",
                ChampionName = "Ivern",
                MissileSpeed = 1300f,
                MissileMinSpeed = 1300f,
                MissileMaxSpeed = 1300f,
                Range = 1100f,
                Width = 65f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Root,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "IvernW",
                ChampionName = "Ivern",
                Range = 1600f,
                MissileSpeed = 1600f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                Radius = 100f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.Wall,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "IvernE",
                ChampionName = "Ivern",
                Range = 750f,
                Delay = 2.25f,
                Radius = 525f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "IvernR",
                ChampionName = "Ivern",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
                OtherMissileNames = new string[] { "IvernRRecast" },
            },
            //daisy
            new SpellInfo()
            {
                MissileName = "IvernRMissile",
                ChampionName = "Ivern",
                MissileSpeed = 1400f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                Range = 800f,
                Width = 100f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Janna
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region JarvanIV
            //q
            new SpellInfo()
            {
                SpellName = "JarvanIVDragonStrike",
                ChampionName = "JarvanIV",
                Range = 770f,
                Width = 70f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "JarvanIVGoldenAegis",
                ChampionName = "JarvanIV",
                Range = 625f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Radius = 400f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "JarvanIVDemacianStandard",
                ChampionName = "JarvanIV",
                Range = 830f,
                MissileSpeed = 1450f,
                MissileMinSpeed = 1450f,
                MissileMaxSpeed = 1450f,
                Radius = 75f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "JarvanIVCataclysm",
                ChampionName = "JarvanIV",
                Range = 650f,
                Radius = 210f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Jax
            //q
            new SpellInfo()
            {
                SpellName = "JaxLeapStrike",
                ChampionName = "Jax",
                Range = 700f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "JaxEmpowerTwo",
                ChampionName = "Jax",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "JaxCounterStrike",
                ChampionName = "Jax",
                Range = 187.5f,
                Radius = 187.5f,
                Delay = 2.25f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "JaxRelentlessAssault",
                ChampionName = "Jax",
                Delay = 8.25f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //add longrange q
            #region Jayce
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q ranged
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w ranged
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.KnockAside,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e ranged
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Wall,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Jhin
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Jinx
            //aa
            new SpellInfo()
            {
                MissileName = "JinxBasicAttack",
                ChampionName = "Jinx",
                MissileSpeed = 2750f,
                MissileMinSpeed = 2750f,
                MissileMaxSpeed = 2750f,
                Range = 625f,
                Radius = 100f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //rocket aa
            new SpellInfo()
            {
                MissileName = "JinxQAttack",
                ChampionName = "Jinx",
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 20f,
                Radius = 100f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
                OtherMissileNames = new string[]
                {
                    "JinxQAttack2",
                },
            },
            //q
            new SpellInfo()
            {
                SpellName = "JinxQ",
                ChampionName = "Jinx",
                Range = 600f,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 0f,
                Radius = 100f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "JinxW",
                ChampionName = "Jinx",
                MissileName = "JinxWMissile",
                Range = 1600f,
                MissileSpeed = 1200f,
                MissileMinSpeed = 1200f,
                MissileMaxSpeed = 1200f,
                Width = 60f,
                Delay = 0.5f,
                OtherMissileNames = new string[]
                {
                    "JinxWMissile",
                },
                CollisionCount = 1,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "JinxE",
                MissileName = "JinxEHit",
                ChampionName = "Jinx",
                MissileSpeed = 1100f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Range = 1200f,
                Radius = 50f,
                //handled under the trap handler
                //SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                //CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "JinxR",
                ChampionName = "Jinx",
                MissileName = "JinxR",
                Range = 250000f,
                MissileSpeed = 1700f,
                MissileMinSpeed = 1700f,
                MissileMaxSpeed = 1700f,
                Width = 140f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Kalista
            //q
            new SpellInfo()
            {
                SpellName = "KalistaMysticShot",
                MissileName = "KalistaMysticShotMisTrue",
                ChampionName = "Kalista",
                Range = 1200f,
                MissileSpeed = 2400f,
                MissileMinSpeed = 2400f,
                MissileMaxSpeed = 2400f,
                Width = 40f,
                //OtherMissileNames = new string[] { "KalistaMysticShotMis" },
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "KalistaW",
                ChampionName = "Kalista",
                Range = int.MaxValue,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "KalistaExpunge",
                MissileName = "KalistaExpungeParticle",
                ChampionName = "Kalista",
                Range = 3000f,
                MissileSpeed = 3000f,
                MissileMinSpeed = 3000f,
                MissileMaxSpeed = 3000f,
                Radius = 1200f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "KalistaRx",
                MissileName = "KalistaRMis",
                ChampionName = "Kalista",
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Range = 1450f,
                Width = 80f,
                //R cast range = 1100
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Karma
            //q
            new SpellInfo()
            {
                SpellName = "KarmaQ",
                ChampionName = "Karma",
                MissileName = "KarmaQMissile",
                MissileSpeed = 1700f,
                MissileMinSpeed = 1700f,
                MissileMaxSpeed = 1700f,
                Range = 1050f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //rq
            new SpellInfo()
            {
                MissileName = "KarmaQMissileMantra",
                ChampionName = "Karma",
                MissileSpeed = 1700f,
                MissileMinSpeed = 1700f,
                MissileMaxSpeed = 1700f,
                Range = 950f,
                Width = 80f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "KarmaSpiritBind",
                ChampionName = "Karma",
                Range = 700f,
                MissileSpeed = 2200f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Width = 60f,
                Radius = 175f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Root,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "KarmaSolKimShield",
                ChampionName = "Karma",
                Range = 800f,
                MissileSpeed = 20f,
                MissileMinSpeed = 20f,
                MissileMaxSpeed = 20f,
                Width = 0f,
                Radius = 100f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "KarmaMantra",
                ChampionName = "Karma",
                Range = 1100f,
                MissileSpeed = 1300f,
                MissileMinSpeed = 1300f,
                MissileMaxSpeed = 1300f,
                Width = 0f,
                Radius = 275f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Karthus
            //q handled by particle databaseq
            /*new SpellInfo()
            {
                SpellName = "KarthusLayWasteA3",
                ChampionName = "Karthus",
                MissileSpeed = 10000f,
                Range = 875f,
                Radius = 160f,
                Delay = 0.25f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
                OtherMissileNames = new string[] { "KarthusLayWasteA1", "KarthusLayWasteA2",},
            },*/
            //w
            new SpellInfo()
            {
                SpellName = "KarthusWallOfPain",
                ChampionName = "Karthus",
                Range = 1000f,
                Width = 5f,
                Radius = 850f,
                ConeDegrees = 45f,
                Delay = 5.25f,
                SpellType = SpellInfo.SpellTypeInfo.Wall,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "KarthusDefile",
                BuffName = "KarthusDefile",
                ChampionName = "Karthus",
                Range = 550f,
                MissileSpeed = 1000f,
                MissileMinSpeed = 1000f,
                MissileMaxSpeed = 1000f,
                Width = 150f,
                Radius = 550f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "KarthusFallenOne",
                ChampionName = "Karthus",
                Range = int.MaxValue,
                Delay = 3.25f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Kassadin
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Katarina
            //q
            new SpellInfo()
            {
                SpellName = "KatarinaQ",
                MissileName = "KatarinaQ",
                ChampionName = "Katarina",
                Range = 675f,
                MissileSpeed = 1800f,
                MissileMinSpeed = 1100f,
                MissileMaxSpeed = 1100f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,

                // kat q bounce
                OtherMissileNames = new string[] { "KatarinaQMis", },
            },
            //w
            new SpellInfo()
            {
                SpellName = "KatarinaW",
                ChampionName = "Katarina",
                Range = 0f,
                Radius = 60f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "KatarinaE",
                ChampionName = "Katarina",
                Range = 725f,
                DashType = SpellInfo.Dashtype.Blink,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "KatarinaR",
                MissileName = "KatarinaRMis",
                ChampionName = "Katarina",
                Range = 550f,
                MissileSpeed = 2400f,
                MissileMinSpeed = 2400f,
                MissileMaxSpeed = 2400f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Kayle
            //q
            new SpellInfo()
            {
                SpellName = "JudicatorReckoning",
                MissileName = "JudicatorReckoning",
                ChampionName = "Kayle",
                Range = 650f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1300f,
                MissileMaxSpeed = 1300f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "JudicatorDivineBlessing",
                ChampionName = "Kayle",
                Range = 900f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "JudicatorRighteousFury",
                ChampionName = "Kayle",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "JudicatorIntervention",
                ChampionName = "Kayle",
                Range = 900f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Kennen
            //aa
            new SpellInfo()
            {
                MissileName = "KennenMegaProc",
                ChampionName = "Kennen",
                MissileSpeed = 1700f,
                MissileMinSpeed = 1700f,
                MissileMaxSpeed = 1700f,
                Range = 200f,
                Width = 0f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //q
            new SpellInfo()
            {
                SpellName = "KennenShurikenHurlMissile1",
                MissileName = "KennenShurikenHurlMissile1",
                ChampionName = "Kennen",
                Range = 1050f,
                MissileSpeed = 1700f,
                MissileMinSpeed = 1700f,
                MissileMaxSpeed = 1700f,
                Width = 50f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "KennenBringTheLight",
                ChampionName = "Kennen",
                Range = 725f,
                MissileSpeed = 20f,
                MissileMinSpeed = 20f,
                MissileMaxSpeed = 20f,
                Width = 0f,
                Radius = 900f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "KennenLightningRush",
                ChampionName = "Kennen",
                Range = 200f,
                MissileSpeed = 20f,
                MissileMinSpeed = 20f,
                MissileMaxSpeed = 20f,
                Radius = 100f,
                Delay = 2.25f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "KennenShurikenStorm",
                ChampionName = "Kennen",
                MissileSpeed = 779.9f,
                MissileMinSpeed = 779.9f,
                MissileMaxSpeed = 779.9f,
                Radius = 550f,
                Delay = 3.25f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region KhaZix
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Kindred
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Kled
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q skarrl
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w skarrl
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e skarrl
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region KogMaw
            //q
            new SpellInfo()
            {
                SpellName = "KogMawQ",
                MissileName = "KogMawQ",
                ChampionName = "KogMaw",
                Range = 1200f,
                MissileSpeed = 1650f,
                MissileMinSpeed = 1650f,
                MissileMaxSpeed = 1650f,
                Width = 70f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "KogMawBioArcaneBarrage",
                ChampionName = "KogMaw",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "KogMawVoidOozeMissile",
                MissileName = "KogMawVoidOozeMissile",
                ChampionName = "KogMaw",
                Range = 1500f,
                MissileSpeed = 1400f,
                MissileMinSpeed = 1400f,
                MissileMaxSpeed = 1400f,
                Width = 120f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //R
            new SpellInfo()
            {
                SpellName = "KogMawLivingArtillery",
                ChampionName = "KogMaw",
                Range = 1200f,
                Radius = 240f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R
            },
            #endregion
            #region LeBlanc
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //rq
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            //rw
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            //re
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //fix lee sin second q
            #region LeeSin
            //q
            new SpellInfo()
            {
                SpellName = "BlindMonkQOne",
                MissileName = "BlindMonkQOne",
                BuffName = "BlindMonkQOne",
                ChampionName = "LeeSin",
                MissileSpeed = 1800f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Range = 1100f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q2
            new SpellInfo()
            {
                //SpellName = "BlindMonkQTwo",
                ChampionName = "LeeSin",
                //BuffName = "BlindMonkQOne",
                Range = 1300f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                DashType = SpellInfo.Dashtype.Linear,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "BlindMonkWOne",
                ChampionName = "LeeSin",
                Range = 700f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Radius = 750f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                DashType = SpellInfo.Dashtype.Linear,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w2
            new SpellInfo()
            {
                SpellName = "BlindMonkWTwo",
                ChampionName = "LeeSin",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "BlindMonkEOne",
                ChampionName = "LeeSin",
                Radius = 425f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e2
            new SpellInfo()
            {
                SpellName = "BlindMonkETwo",
                MissileName = "BlindMonkETwoMissile",
                ChampionName = "LeeSin",
                MissileSpeed = 1600f,
                MissileMinSpeed = 1400f,
                MissileMaxSpeed = 1400f,
                Range = 575f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "BlindMonkRKick",
                ChampionName = "LeeSin",
                Range = 375f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Width = 0f,
                Radius = 375f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Leona
            //q
            new SpellInfo()
            {
                SpellName = "LeonaShieldOfDaybreak",
                ChampionName = "Leona",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "LeonaSolarBarrier",
                ChampionName = "Leona",
                Radius = 500f,
                Delay = 3.25f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "LeonaZenithBlade",
                MissileName = "LeonaZenithBladeMissile",
                ChampionName = "Leona",
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Range = 900f,
                Width = 70f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Root,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "LeonaSolarFlare",
                ChampionName = "Leona",
                Range = 1200f,
                Radius = 120f,
                SecondRadius = 225f,
                Delay = 0.625f + 0.25f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Lissandra
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Lucian
            //q
            new SpellInfo()
            {
                SpellName = "LucianQ",
                ChampionName = "Lucian",
                Range = 500f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Width = 65f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "LucianW",
                MissileName = "LucianWMissile",
                ChampionName = "Lucian",
                Range = 900f,
                MissileSpeed = 1600f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                Width = 55f,    
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "LucianE",
                ChampionName = "Lucian",
                Range = 425f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Width = 50f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "LucianR",
                MissileName = "LucianRMissile",
                ChampionName = "Lucian",
                Range = 1200f,
                MissileSpeed = 2800f,
                MissileMinSpeed = 2800f,
                MissileMaxSpeed = 2800f,
                Width = 110f,//possible 60 width
                OtherMissileNames = new string[] { "LucianRMissileOffhand", },
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Lulu
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Polymorph,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Lux
            //q
            new SpellInfo()
            {
                SpellName = "LuxLightBinding",
                MissileName = "LuxLightBindingMis",
                ChampionName = "Lux",
                Range = 1200f,
                MissileSpeed = 1200f,
                MissileMinSpeed = 1200f,
                MissileMaxSpeed = 1200f,
                Width = 70f,
                OtherMissileNames = new string[] { "LuxLightBindingDummy" },
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "LuxPrismaticWave",
                MissileName = "LuxPrismaticWaveMissile",
                ChampionName = "Lux",
                Range = 1175f,
                MissileSpeed = 2200f,
                MissileMinSpeed = 2200f,
                MissileMaxSpeed = 2200f,
                Width = 110f,
                OtherMissileNames = new string[] { "LuxPrismaticWaveReturn" },
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            //this is the missile. The ball is handled by Particle Database
            new SpellInfo()
            {
                SpellName = "LuxLightStrikeKugel",
                MissileName = "LuxLightStrikeKugel",
                ChampionName = "Lux",
                Range = 1100f,
                MissileSpeed = 1300f,
                MissileMinSpeed = 1300f,
                MissileMaxSpeed = 1300f,
                canVaryInLength = true,
                Radius = 330f,
                Width = 55f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "LuxMaliceCannon",
                ChampionName = "Lux",
                Range = 3500f,
                MissileSpeed = 3000f,
                MissileMinSpeed = 3000f,
                MissileMaxSpeed = 3000f,
                Width = 250f,
                Delay = 0.75f,
                Radius = 250f,
                OtherMissileNames = new string[] { "LuxMaliceCannonMis", "LuxRVfxMis" },
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Malphite
            //q
            new SpellInfo()
            {
                SpellName = "SeismicShard",
                MissileName = "SeismicShard",
                ChampionName = "Malphite",
                Range = 625f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "Obduracy",
                ChampionName = "Malphite",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "Landslide",
                ChampionName = "Malphite",
                Range = 400f,
                Radius = 400f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "UFSlash",
                ChampionName = "Malphite",
                Range = 1000f,
                MissileSpeed = 700f,
                MissileMinSpeed = 700f,
                MissileMaxSpeed = 700f,
                Width = 160f,
                Radius = 300f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Malzahar
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Wall,
                CCtype = SpellInfo.CrowdControlType.Silence,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Suppression,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Maokai
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Root,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region MasterYi
            //q
            new SpellInfo()
            {
                SpellName = "AlphaStrike",
                MissileName = "AlphaStrikeMissile",
                ChampionName = "MasterYi",
                Range = 600f,
                MissileSpeed = 4000f,
                MissileMinSpeed = 4000f,
                MissileMaxSpeed = 4000f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
                DashType = SpellInfo.Dashtype.Blink,
            },
            //w
            new SpellInfo()
            {
                SpellName = "Meditate",
                ChampionName = "MasterYi",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "WujuStyle",
                ChampionName = "MasterYi",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "Highlander",
                ChampionName = "MasterYi",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region MissFortune
            //q
            new SpellInfo()
            {
                SpellName = "MissFortuneRicochetShot",
                MissileName = "MissFortuneRicochetShot",
                ChampionName = "MissFortune",
                Range = 550f,
                MissileSpeed = 1400f,
                MissileMinSpeed = 1400f,
                MissileMaxSpeed = 1400f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q richochet bounce - most damage
            new SpellInfo()
            {
                MissileName = "MissFortuneRShotExtra",
                ChampionName = "MissFortune",
                MissileSpeed = 1400f,
                MissileMinSpeed = 1400f,
                MissileMaxSpeed = 1400f,
                Range = 575f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "MissFortuneViciousStrikes",
                ChampionName = "MissFortune",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "MissFortuneScattershot",
                ChampionName = "MissFortune",
                Range = 1000f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Radius = 350f,
                Delay = 2.25f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "MissFortuneBulletTime",
                //MissileName = "MissFortuneBullets",
                ChampionName = "MissFortune",
                BuffName = "missfortunebulletsound",
                Range = 1450f,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                //Delay = 3.25f,
                Width = 40f,
                Radius = 210f,
                ConeDegrees = 17f,
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Mordekaiser
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Morgana
            //q
            new SpellInfo()
            {
                SpellName = "DarkBindingMissile",
                MissileName = "DarkBindingMissile",
                ChampionName = "Morgana",
                MissileSpeed = 1200f,
                MissileMinSpeed = 1200f,
                MissileMaxSpeed = 1200f,
                Range = 1300f,
                Width = 90f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Root,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                //handled as particle
                //SpellName = "TormentedSoil",
                ChampionName = "Morgana",
                Range = 900f,
                MissileSpeed = 20f,
                MissileMinSpeed = 20f,
                MissileMaxSpeed = 20f,
                Width = 0f,
                Radius = 280f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "BlackShield",
                ChampionName = "Morgana",
                Range = 800f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "SoulShackles",
                ChampionName = "Morgana",
                Range = 625f,
                Radius = 625f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Nami
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.MovingWall,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Nasus
            //q
            new SpellInfo()
            {
                SpellName = "NasusQ",
                ChampionName = "Nasus",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "NasusW",
                ChampionName = "Nasus",
                Range = 600f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "NasusE",
                ChampionName = "Nasus",
                Range = 650f,
                Radius = 380f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "NasusR",
                ChampionName = "Nasus",
                Delay = 15.25f,
                Radius = 175f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Nautilus
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Pull,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Nidalee
            //q
            new SpellInfo()
            {
                SpellName = "JavelinToss",
                MissileName = "JavelinToss",
                ChampionName = "Nidalee",
                Range = 1500f,
                MissileSpeed = 1300f,
                MissileMinSpeed = 1300f,
                MissileMaxSpeed = 1300f,
                Width = 40f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q tiger
            new SpellInfo()
            {
                SpellName = "Takedown",
                ChampionName = "Nidalee",
                Range = 500f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Width = 0f,
                Radius = 20f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w handled as trap
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w tiger
            new SpellInfo()
            {
                SpellName = "Pounce",
                ChampionName = "Nidalee",
                Range = 200f,
                MissileSpeed = 0f,
                MissileMinSpeed = 0f,
                MissileMaxSpeed = 0f,
                Radius = 75f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "PrimalSurge",
                ChampionName = "Nidalee",
                Range = 600f,
                MissileSpeed = 0f,
                MissileMinSpeed = 0f,
                MissileMaxSpeed = 0f,
                Width = 0f,
                Radius = 350f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e tiger
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "AspectOfTheCougar",
                ChampionName = "Nidalee",
                Range = 20f,
                MissileSpeed = 943.8f,
                MissileMinSpeed = 943.8f,
                MissileMaxSpeed = 943.8f,
                Width = 0f,
                Radius = 100f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Nocturne
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Fear,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Nearsight,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Nunu
            //q
            new SpellInfo()
            {
                SpellName = "Consume",
                ChampionName = "Nunu",
                Range = 125f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "BloodBoil",
                ChampionName = "Nunu",
                Range = 700f,
                MissileSpeed = 0f,
                MissileMinSpeed = 0f,
                MissileMaxSpeed = 0f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "IceBlast",
                MissileName = "IceBlast",
                ChampionName = "Nunu",
                Range = 550f,
                MissileSpeed = 1000f,
                MissileMinSpeed = 1000f,
                MissileMaxSpeed = 1000f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "AbsoluteZero",
                ChampionName = "Nunu",
                Range = 650f,
                MissileSpeed = 828.5f,
                MissileMinSpeed = 828.5f,
                MissileMaxSpeed = 828.5f,
                Width = 0f,
                Radius = 650f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Olaf
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Orianna
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Pantheon
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Poppy
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Quinn
            //aa
            new SpellInfo()
            {
                MissileName = "QuinnBasicAttack",
                ChampionName = "Quinn",
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Range = 625f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //aa enhanced
            new SpellInfo()
            {
                MissileName = "QuinnWEnhanced",
                ChampionName = "Quinn",
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Range = 525f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //q
            new SpellInfo()
            {
                SpellName = "QuinnQ",
                MissileName = "QuinnQ",
                ChampionName = "Quinn",
                MissileSpeed = 1550f,
                MissileMinSpeed = 1550f,
                MissileMaxSpeed = 1550f,
                Range = 1050f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Nearsight,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                //gives vision
                SpellName = "QuinnW",
                ChampionName = "Quinn",
                Range = 2500f,
                MissileSpeed = 20f,
                MissileMinSpeed = 20f,
                MissileMaxSpeed = 20f,
                Width = 0f,
                Radius = 1200f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
                OtherMissileNames = new string[] { "QuinnWTimingMissile", },
            },
            //e
            new SpellInfo()
            {
                SpellName = "QuinnE",
                ChampionName = "Quinn",
                Range = 600f,
                MissileSpeed = 20f,
                MissileMinSpeed = 20f,
                MissileMaxSpeed = 20f,
                Width = 0f,
                Radius = 250f,
                ConeDegrees = 45f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            //the shards when leaving ult form
            new SpellInfo()
            {
                SpellName = "QuinnR",
                ChampionName = "Quinn",
                Range = 650f,
                MissileSpeed = 2200f,
                MissileMinSpeed = 2200f,
                MissileMaxSpeed = 2200f,
                Width = 200f,
                Radius = 300f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            //quinn r dmg
            new SpellInfo()
            {
                SpellName = "QuinnRFinale",
                ChampionName = "Quinn",
                Range = 700f,
                Radius = 700f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Rammus
            //q
            new SpellInfo()
            {
                SpellName = "PowerBall",
                ChampionName = "Rammus",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "DefensiveBallCurl",
                ChampionName = "Rammus",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "PuncturingTaunt",
                ChampionName = "Rammus",
                Range = 325f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Taunt,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "Tremors2",
                ChampionName = "Rammus",
                Radius = 375f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //add reksai unburrow
            #region RekSai
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q burrowed
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w burrowed
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e burrowed
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Renekton
            //q
            new SpellInfo()
            {
                SpellName = "RenektonCleave",
                ChampionName = "Renekton",
                Range = 325f,
                Radius = 325f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w just casting
            new SpellInfo()
            {
                SpellName = "RenektonPreExecute",
                ChampionName = "Renekton",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w during auto
            new SpellInfo()
            {
                SpellName = "RenektonExecute",
                ChampionName = "Renekton",
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w during auto with enhanced w 
            new SpellInfo()
            {
                SpellName = "RenektonSuperExecute",
                ChampionName = "Renekton",
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //slice
            new SpellInfo()
            {
                SpellName = "RenektonSliceAndDice",
                ChampionName = "Renekton",
                Range = 450,
                Width = 50f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //dice
            new SpellInfo()
            {
                SpellName = "RenektonDice",
                ChampionName = "Renekton",
                Range = 450,
                Width = 50f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "RenektonReignOfTheTyrant",
                ChampionName = "Renekton",
                Range = 175f,
                Radius = 175f,
                Delay = 15.25f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Rengar
            //q
            new SpellInfo()
            {
                SpellName = "RengarQ",
                ChampionName = "Rengar",
                Range = 325f,
                ConeAndLinearRange = 450f,
                MissileSpeed = 3000f,
                MissileMinSpeed = 3000f,
                MissileMaxSpeed = 3000f,
                Width = 55f,
                Radius = 325f,
                ConeDegrees = 90f,
                SpellType = SpellInfo.SpellTypeInfo.ConeAndLinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q emp
            new SpellInfo()
            {
                SpellName = "RengarQEmp",
                ChampionName = "Rengar",
                Range = 300f,
                ConeAndLinearRange = 450f,
                MissileSpeed = 3000f,
                MissileMinSpeed = 3000f,
                MissileMaxSpeed = 3000f,
                Width = 55f,
                Radius = 300f,
                ConeDegrees = 90f,
                SpellType = SpellInfo.SpellTypeInfo.ConeAndLinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "RengarW",
                ChampionName = "Rengar",
                Range = 450f,
                Radius = 450f,
                ConeDegrees = 45f,

                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w emp
            new SpellInfo()
            {
                SpellName = "RengarWEmp",
                ChampionName = "Rengar",
                Range = 450f,
                Radius = 450f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "RengarE",
                MissileName = "RengarEMis",
                ChampionName = "Rengar",
                Range = 1000f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Width = 70f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e emp
            new SpellInfo()
            {
                SpellName = "RengarEEmp",
                MissileName = "RengarEEmpMis",
                ChampionName = "Rengar",
                Range = 1000f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Width = 70f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "RengarR",
                ChampionName = "Rengar",
                Range = 2000f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Riven
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion  
            #region Rumble
            //q
            new SpellInfo()
            {
                ChampionName = "Rumble",
                SpellName = "RumbleFlameThrower",
                BuffName = "RumbleFlameThrower",
                Range = 600f,
                MissileSpeed = 5000f,
                MissileMinSpeed = 5000f,
                MissileMaxSpeed = 5000f,
                Width = 500f,
                Radius = 500f,
                ConeDegrees = 32f,
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "RumbleShield",
                ChampionName = "Rumble",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                MissileName = "RumbleGrenadeMissile",
                ChampionName = "Rumble",
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Range = 950f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r Handled by Particle Manager
            /*new SpellInfo()
            {
                SpellName = "RumbleCarpetBomb",
                //MissileName = "RumbleCarpetBombMissile",
                ChampionName = "Rumble",
                Range = 1700f,
                Width = 200f,
                Delay = 5.25f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },*/
            #endregion
            //add Ryze E bounce "RyzeEMissile" slot 47
            #region Ryze
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Sejuani
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //add shaco jack in the box to trap database
            #region Shaco
            //q
            new SpellInfo()
            {
                SpellName = "Deceive",
                ChampionName = "Shaco",
                Range = 400f,
                DashType = SpellInfo.Dashtype.Blink,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Fear,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "TwoShivPoison",
                MissileName = "TwoShivPoison",
                ChampionName = "Shaco",
                Range = 625f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "HallucinateFull",
                ChampionName = "Shaco",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            //r movement
            new SpellInfo()
            {
                SpellName = "HallucinateGuide",
                ChampionName = "Shaco",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Shen
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Taunt,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Shyvana
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q drag
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w drag
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e drag
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Singed
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "MegaAdhesive",
                ChampionName = "Singed",
                Range = 1000f,
                MissileSpeed = 700f,
                MissileMinSpeed = 700f,
                MissileMaxSpeed = 700f,
                Width = 0f,
                Delay = 5.25f,
                Radius = 265f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "Fling",
                ChampionName = "Singed",
                Range = 125f,
                MissileSpeed = 0f,
                MissileMinSpeed = 0f,
                MissileMaxSpeed = 0f,
                Width = 0f,
                Radius = 100f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Sion
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Sivir
            //aa
            new SpellInfo()
            {
                MissileName = "SivirBasicAttack",
                ChampionName = "Sivir",
                MissileSpeed = 1750f,
                MissileMinSpeed = 1400f,
                MissileMaxSpeed = 1400f,
                Range = 600f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //aa
            new SpellInfo()
            {
                MissileName = "SivirCritAttack",
                ChampionName = "Sivir",
                MissileSpeed = 1750f,
                MissileMinSpeed = 1750f,
                MissileMaxSpeed = 1750f,
                Range = 600f,
                Width = 0f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //q
            new SpellInfo()
            {
                SpellName = "SivirQ",
                MissileName = "SivirQMissile",
                ChampionName = "Sivir",
                Range = 1250f,
                MissileSpeed = 1350f,
                MissileMinSpeed = 1350f,
                MissileMaxSpeed = 1350f,
                Width = 90f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q
            new SpellInfo()
            {
                SpellName = "SivirQ",
                MissileName = "SivirQMissileReturn",
                ChampionName = "Sivir",
                Range = 25000f,
                MissileSpeed = 1350f,
                MissileMinSpeed = 1350f,
                MissileMaxSpeed = 1350f,
                Width = 100f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "SivirW",
                MissileName = "SivirWAttackBounce",
                ChampionName = "Sivir",
                MissileSpeed = 700f,
                MissileMinSpeed = 700f,
                MissileMaxSpeed = 700f,
                Range = 25000f,
                Width = 10f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //w
            new SpellInfo()
            {
                MissileName = "SivirWAttack",
                ChampionName = "Sivir",
                MissileSpeed = 1750f,
                MissileMinSpeed = 1750f,
                MissileMaxSpeed = 1750f,
                Range = 25000f,
                Width = 10f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //e
            new SpellInfo()
            {
                SpellName = "SivirE",
                ChampionName = "Sivir",
                Delay = 1.75f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "SivirR",
                ChampionName = "Sivir",
                Radius = 1000f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Skarner
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Suppression,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Sona
            //q
            new SpellInfo()
            {
                SpellName = "SonaQ",
                MissileName = "SonaQMissile",
                ChampionName = "Sona",
                Range = 825f,
                MissileSpeed = 1300f,
                MissileMinSpeed = 1300f,
                MissileMaxSpeed = 1300f,
                OtherMissileNames = new string[] { "SonaQAttackUpgrade" },
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                ChampionName = "Sona",
                SpellName = "SonaW",
                Range = 1000f,
                Radius = 1000f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w chord
            new SpellInfo()
            {
                ChampionName = "Sona",
                MissileName = "SonaWMissile",
                MissileSpeed = 1300f,
                MissileMinSpeed = 1300f,
                MissileMaxSpeed = 1300f,
                Range = 1000f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "SonaE",
                ChampionName = "Sona",
                Range = 1000f,
                Radius = 1000f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e chord
            new SpellInfo()
            {
                MissileName = "SonaEAttackUpgrade",
                ChampionName = "Sona",
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "SonaR",
                MissileName = "SonaR",
                ChampionName = "Sona",
                Range = 1000f,
                MissileSpeed = 2400f,
                MissileMinSpeed = 2400f,
                MissileMaxSpeed = 2400f,
                Width = 140f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Soraka
            //q
            new SpellInfo()
            {
                SpellName = "SorakaQ",
                MissileName = "SorakaQMissile",
                ChampionName = "Soraka",
                Range = 800f,
                MissileSpeed = 1100f,
                MissileMinSpeed = 1100f,
                MissileMaxSpeed = 1100f,
                Radius = 230f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "SorakaW",
                ChampionName = "Soraka",
                Range = 550f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "SorakaE",
                ChampionName = "Soraka",
                Range = 875f,
                Radius = 250f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Silence,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "SorakaR",
                ChampionName = "Soraka",
                Range = int.MaxValue,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Swain
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Syndra
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region TahmKench
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Suppression,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Talon
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.ConeSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Taric
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "TaricW",
                ChampionName = "Taric",
                Range = 800f,
                MissileSpeed = 1700f,
                MissileMinSpeed = 1700f,
                MissileMaxSpeed = 1700f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "TaricR",
                ChampionName = "Taric",
                Range = 400f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                Width = 0f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Teemo
            //aa
            new SpellInfo()
            {
                SpellName = "ToxicShotAttack",
                MissileName = "ToxicShotAttack",
                ChampionName = "Teemo",
                Range = 600f,
                MissileSpeed = 1300f,
                MissileMinSpeed = 1300f,
                MissileMaxSpeed = 1300f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Auto,
            },
            //q
            new SpellInfo()
            {
                SpellName = "BlindingDart",
                MissileName = "BlindingDart",
                ChampionName = "Teemo",
                Range = 680f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Blind,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                //SpellName = "TeemoRCast",
                //MissileName = "BantamTrap",
                ChampionName = "Teemo",
                Range = 400f,
                MissileSpeed = 1000f,
                MissileMinSpeed = 1000f,
                MissileMaxSpeed = 1000f,
                Width = 120f,
                Radius = 135f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.R,
            },
            //r2
            new SpellInfo()
            {
                SpellName = "TeemoRCast",
                MissileName = "BantamTrapBounceSpell",
                ChampionName = "Teemo",
                Range = 400f,
                MissileSpeed = 1000f,
                MissileMinSpeed = 1000f,
                MissileMaxSpeed = 1000f,
                Width = 120f,
                Radius = 135f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Thresh
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Pull,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Wall,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Tristana
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Trundle
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Tryndamere
            //q
            new SpellInfo()
            {
                SpellName = "TryndamereQ",
                ChampionName = "Tryndamere",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "TryndamereW",
                ChampionName = "Tryndamere",
                Range = 850f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "TryndamereE",
                ChampionName = "Tryndamere",
                Range = 660f,
                MissileSpeed = 700f,
                MissileMinSpeed = 700f,
                MissileMaxSpeed = 700f,
                Width = 160f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "UndyingRage",
                ChampionName = "Tryndamere",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region TwistedFate
            //q
            new SpellInfo()
            {
                SpellName = "WildCards",
                MissileName = "SealFateMissile",
                ChampionName = "TwistedFate",
                Range = 1450f,
                MissileSpeed = 1000f,
                MissileMinSpeed = 1000f,
                MissileMaxSpeed = 1000f,
                Width = 40f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "PickACard",
                ChampionName = "TwistedFate",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //blue card
            new SpellInfo()
            {
                SpellName = "BlueCardPreAttack",
                MissileName = "BlueCardAttack",
                ChampionName = "TwistedFate",
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //red card
            new SpellInfo()
            {
                SpellName = "PickACard",
                ChampionName = "TwistedFate",
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //red card aoe
            new SpellInfo()
            {
                SpellName = "PickACard",
                ChampionName = "TwistedFate",
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //yellow card
            new SpellInfo()
            {
                SpellName = "GoldCardPreAttack",
                MissileName = "GoldCardAttack",
                ChampionName = "TwistedFate",
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                MissileName = "TwistedFateBasicAttack4",
                ChampionName = "TwistedFate",
                MissileSpeed = 1500f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r vision
            new SpellInfo()
            {
                SpellName = "Destiny",
                ChampionName = "TwistedFate",
                Range = 5500f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            //r teleport
            new SpellInfo()
            {
                SpellName = "Gate",
                ChampionName = "TwistedFate",
                Range = 5500f,
                DashType = SpellInfo.Dashtype.Blink,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Twitch
            //q
            new SpellInfo()
            {
                SpellName = "TwitchHideInShadows",
                ChampionName = "Twitch",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "TwitchVenomCask",
                MissileName = "TwitchVenomCaskMissile",
                ChampionName = "Twitch",
                Range = 1100f,//900?
                MissileSpeed = 1400f,
                Delay = 3.25f,
                Radius = 275f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "TwitchExpunge",
                MissileName = "TwitchEParticle",
                ChampionName = "Twitch",
                MissileSpeed = 3000f,
                MissileMinSpeed = 3000f,
                MissileMaxSpeed = 3000f,
                Range = 1200f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "TwitchFullAutomatic",
                ChampionName = "Twitch",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Udyr
            //q
            new SpellInfo()
            {
                SpellName = "UdyrTigerStance",
                ChampionName = "Udyr",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "UdyrTurtleStance",
                ChampionName = "Udyr",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "UdyrBearStance",
                ChampionName = "Udyr",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "UdyrPheonixStance",
                ChampionName = "Udyr",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Urgot
            //q
            new SpellInfo()
            {
                SpellName = "UrgotHeatseekingLineMissile",
                MissileName = "UrgotHeatseekingLineMissile",
                ChampionName = "Urgot",
                Range = 1000f,
                MissileSpeed = 1600f,
                MissileMinSpeed = 1600f,
                MissileMaxSpeed = 1600f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //lock on Q
            new SpellInfo()
            {
                SpellName = "UrgotHeatseekingHomeMissile",
                MissileName = "UrgotHeatseekingHomeMissile",
                ChampionName = "Urgot",
                Range = 1200f,
                MissileSpeed = 1800f,
                MissileMinSpeed = 1800f,
                MissileMaxSpeed = 1800f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "UrgotTerrorCapacitorActive2",
                ChampionName = "Urgot",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "UrgotPlasmaGrenade",
                MissileName = "UrgotPlasmaGrenadeBoom",
                ChampionName = "Urgot",
                Range = 1100f,
                Width = 120f,
                Radius = 250f,
                Delay = 0.25f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "UrgotSwap2",
                ChampionName = "Urgot",
                Range = 550f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Suppression,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Varus
            //q
            new SpellInfo()
            {
                MissileName = "VarusQMissile",
                //SpellName = "VarusQ",
                ChampionName = "Varus",
                MissileSpeed = 1900f,
                MissileMinSpeed = 1900f,
                MissileMaxSpeed = 1900f,
                Range = 2000f,
                Width = 70f,
                canVaryInLength = true,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "VarusEMissile",
                MissileName = "VarusEMissile",
                ChampionName = "Varus",
                Range = 1100f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Width = 120f,
                Radius = 210f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "VarusR",
                MissileName = "VarusRMissile",
                ChampionName = "Varus",
                Range = 1250f,
                MissileSpeed = 1950f,
                MissileMinSpeed = 1950f,
                MissileMaxSpeed = 1950f,
                Width = 120f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Vayne
            //q
            new SpellInfo()
            {
                SpellName = "VayneTumble",
                ChampionName = "Vayne",
                Range = 300f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                DashType = SpellInfo.Dashtype.Linear,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                //passive
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "VayneCondemnMissile",
                MissileName = "VayneCondemnMissile",
                ChampionName = "Vayne",
                Range = 550f,
                MissileSpeed = 2200f,
                MissileMinSpeed = 2200f,
                MissileMaxSpeed = 2200f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "VayneInquisition",
                ChampionName = "Vayne",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Veigar
            //q
            new SpellInfo()
            {
                SpellName = "VeigarBalefulStrike",
                MissileName = "VeigarBalefulStrikeMis",
                ChampionName = "Veigar",
                Range = 950f,
                MissileSpeed = 2200f,
                MissileMinSpeed = 2200f,
                MissileMaxSpeed = 2200f,
                Width = 70f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "VeigarDarkMatter",
                ChampionName = "Veigar",
                canVaryInLength = true,
                Range = 900f,
                Delay = 1.5f,
                Radius = 225f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "VeigarEventHorizon",
                ChampionName = "Veigar",
                Range = 700f,
                Radius = 390f,
                Delay = 3.75f,
                SecondRadius = 350f,
                SpellType = SpellInfo.SpellTypeInfo.CircularWall,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "VeigarR",
                MissileName = "VeigarR",
                ChampionName = "Veigar",
                Range = 650f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region VelKoz
            //q
            new SpellInfo()
            {
                SpellName = "VelkozQ",
                ChampionName = "Velkoz",
                MissileName = "VelkozQMissile",
                MissileSpeed = 1300f,
                MissileMinSpeed = 1300f,
                MissileMaxSpeed = 1300f,
                Range = 1100f,
                Width = 50f,
                CollisionCount = 1,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q split
            new SpellInfo()
            {
                SpellName = "VelkozQ",
                MissileName = "VelkozQMissileSplit",
                ChampionName = "Velkoz",
                MissileSpeed = 2100f,
                MissileMinSpeed = 2100f,
                MissileMaxSpeed = 2100f,
                Range = 1100f,
                Width = 45f,
                CollisionCount = 1,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "VelkozW",
                MissileName = "VelkozWMissile",
                ChampionName = "Velkoz",
                MissileSpeed = 1700f,
                MissileMinSpeed = 1700f,
                MissileMaxSpeed = 1700f,
                Range = 1200f,
                Width = 87.5f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "VelkozE",
                MissileName = "VelkozEMissile",
                ChampionName = "Velkoz",
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Range = 1100f,
                Width = 120f,
                Radius = 225f,
                TravelTime = -1f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "VelkozR",
                ChampionName = "Velkoz",
                Range = 1550f,
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Width = 10f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Vi
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Viktor
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Vladimir
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Volibear
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Warwick
            //q
            new SpellInfo()
            {
                SpellName = "HungeringStrike",
                ChampionName = "Warwick",
                Range = 400f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "HuntersCall",
                ChampionName = "Warwick",
                Range = 1200f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "BloodScent",
                ChampionName = "Warwick",
                Range = 1600f,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "InfiniteDuress",
                ChampionName = "Warwick",
                Range = 700f,
                DashType = SpellInfo.Dashtype.Blink,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Suppression,
                Slot = SpellInfo.SpellSlot.R,
            },
            //r channel
            new SpellInfo()
            {
                SpellName = "InfiniteDuressChannel",
                ChampionName = "Warwick",
                Range = 700f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Suppression,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Wukong
            //q
            new SpellInfo()
            {
                SpellName = "MonkeyKingDoubleAttack",
                ChampionName = "MonkeyKing",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "MonkeyKingDecoy",
                ChampionName = "MonkeyKing",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "MonkeyKingNimbus",
                ChampionName = "MonkeyKing",
                Range = 650f,
                MissileSpeed = 2200f,
                MissileMinSpeed = 2200f,
                MissileMaxSpeed = 2200f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "MonkeyKingSpinToWin",
                ChampionName = "MonkeyKing",
                Range = 162.5f,
                MissileSpeed = 700f,
                MissileMinSpeed = 700f,
                MissileMaxSpeed = 700f,
                Width = 162.5f,
                Radius = 162.5f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Xerath
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region XinZhao
            //q
            new SpellInfo()
            {
                SpellName = "XenZhaoComboTarget",
                ChampionName = "XinZhao",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "XenZhaoBattleCry",
                ChampionName = "XinZhao",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "XenZhaoSweep",
                ChampionName = "XinZhao",
                Range = 600f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "XenZhaoParry",
                ChampionName = "XinZhao",
                Range = 187.5f,
                Radius = 187.5f,
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //On Q cast, if Yasuo casted E is dashing (Yasuo.DummySpell) Q has a circular radius of 3.75f
            #region Yasuo
            //q
            new SpellInfo()
            {
                SpellName = "YasuoQ",
                ChampionName = "Yasuo",
                Range = 520f,
                MissileSpeed = 0f,
                MissileMinSpeed = 0f,
                MissileMaxSpeed = 0f,
                Width = 55f,
                OtherMissileNames = new string[] { "YasuoQ2", "YasuoQW", "YasuoQ2W", },
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //q3
            new SpellInfo()
            {
                SpellName = "YasuoQ3",
                MissileName = "YasuoQ3Mis",
                ChampionName = "Yasuo",
                Range = 1000f,
                MissileSpeed = 1200f,
                MissileMinSpeed = 1200f,
                MissileMaxSpeed = 1200f,
                Width = 90f,
                Radius = 100f,
                ConeDegrees = 45f,
                OtherMissileNames = new string[] { "YasuoQ3W", },
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "YasuoWMovingWall",
                MissileName = "YasuoWMovingWallMisL",
                ChampionName = "Yasuo",
                Range = 6000f,
                MissileSpeed = 850f,
                MissileMinSpeed = 850f,
                MissileMaxSpeed = 850f,
                Width = 350f,
                SpellType = SpellInfo.SpellTypeInfo.Wall,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "YasuoDashWrapper",
                ChampionName = "Yasuo",
                Range = 475f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //IS EING
            new SpellInfo()
            {
                SpellName = "YasuoDummySpell",
                ChampionName = "Yasuo",
                Range = 400f,
                MissileSpeed = 500f,
                MissileMinSpeed = 500f,
                MissileMaxSpeed = 500f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "YasuoRKnockUpComboW",
                MissileName = "TempYasuoRMissile",
                ChampionName = "Yasuo",
                Range = 1200f,
                OtherMissileNames = new string[] { "YasuoRDummySpell" },
                DashType = SpellInfo.Dashtype.Blink,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.Suspension,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Yorick
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Zac
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.SelfActive,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //zeds spells will originate from shadows
            #region Zed
            //q
            new SpellInfo()
            {
                SpellName = "ZedQ",
                MissileName = "ZedQMissile",
                ChampionName = "Zed",
                Range = 925f,
                MissileSpeed = 1700f,
                MissileMinSpeed = 1700f,
                MissileMaxSpeed = 1700f,
                Width = 50f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "ZedW",
                MissileName = "ZedWMissile",
                ChampionName = "Zed",
                Range = 400f,
                MissileSpeed = 1750f,
                MissileMinSpeed = 1750f,
                MissileMaxSpeed = 1750f,
                Width = 60f,
                DashType = SpellInfo.Dashtype.Linear,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //w second cast to blink
            new SpellInfo()
            {
                SpellName = "ZedW2",
                ChampionName = "Zed",
                DashType = SpellInfo.Dashtype.Blink,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellName = "ZedE",
                ChampionName = "Zed",
                Radius = 290f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "ZedR",
                ChampionName = "Zed",
                Range = 625f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            //r second cast to blink
            new SpellInfo()
            {
                SpellName = "ZedR2",
                ChampionName = "Zed",
                Range = 400f,
                DashType = SpellInfo.Dashtype.Blink,
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Ziggs
            //q
            new SpellInfo()
            {
                SpellName = "ZiggsQ",
                MissileName = "ZiggsQSpell",
                ChampionName = "Ziggs",
                Range = 1625f,
                MissileSpeed = 1750f,
                MissileMinSpeed = 1750f,
                MissileMaxSpeed = 1750f,
                Width = 120f,
                Radius = 125f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
                canVaryInLength = true,
                OtherMissileNames = new string[]
                {
                    "ZiggsQSpell2",
                    "ZiggsQSpell3",
                },
            },
            //w
            new SpellInfo()
            {
                SpellName = "ZiggsW",
                MissileName = "ZiggsW",
                ChampionName = "Ziggs",
                Range = 1000f,
                MissileSpeed = 1750f,
                MissileMinSpeed = 1750f,
                MissileMaxSpeed = 1750f,
                Width = 0f,
                Radius = 275f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockBack,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                MissileName = "ZiggsE",
                ChampionName = "Ziggs",
                MissileSpeed = 1500f,
                MissileMinSpeed = 1500f,
                MissileMaxSpeed = 1500f,
                Range = 900f,
                Width = 60f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
                OtherMissileNames = new string[] { "ZiggsE2", "ZiggsE3" }
            },
            //r
            new SpellInfo()
            {
                SpellName = "ZiggsR",
                ChampionName = "Ziggs",
                MissileName = "ZiggsRBoom",
                Range = 5000f,
                MissileSpeed = 1750f,
                MissileMinSpeed = 1750f,
                MissileMaxSpeed = 1750f,
                Width = 0f,
                Radius = 250f,
                SecondRadius = 500f,
                ConeDegrees = 45f,
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            #region Zilean
            //q
            new SpellInfo()
            {
                SpellName = "ZileanQ",
                MissileName = "ZileanQMissile",
                ChampionName = "Zilean",
                Range = 900f,
                MissileSpeed = 2000f,
                MissileMinSpeed = 2000f,
                MissileMaxSpeed = 2000f,
                Radius = 150f,
                OtherMissileNames = new string[] { "ZileanQAttachMissileMinion" },
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.Stun,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellName = "ZileanW",
                ChampionName = "Zilean",
                SpellType = SpellInfo.SpellTypeInfo.PassiveActive,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e speed up
            new SpellInfo()
            {
                SpellName = "TimeWarp",
                ChampionName = "Zilean",
                Range = 550f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.E,
            },
            //e slow down
            new SpellInfo()
            {
                SpellName = "Rewind",
                ChampionName = "Zilean",
                Range = 550f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.Slow,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellName = "ChronoShift",
                ChampionName = "Zilean",
                Range = 900f,
                SpellType = SpellInfo.SpellTypeInfo.Targeted,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
            //add zyra plants
            #region Zyra
            //q
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.Wall,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.Q,
            },
            //w
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.None,
                Slot = SpellInfo.SpellSlot.W,
            },
            //e
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.LinearSkillshot,
                CCtype = SpellInfo.CrowdControlType.Root,
                Slot = SpellInfo.SpellSlot.E,
            },
            //r
            new SpellInfo()
            {
                SpellType = SpellInfo.SpellTypeInfo.CircularSkillshot,
                CCtype = SpellInfo.CrowdControlType.KnockUp,
                Slot = SpellInfo.SpellSlot.R,
            },
            #endregion
        };
        #endregion
        
        public static SpellInfo GetSpellInfo(string spellOrMissileName)
        {
            foreach (SpellInfo info in SpellList)
            {
                if (info.SpellName == spellOrMissileName || info.MissileName == spellOrMissileName)
                    return info;
                foreach (string otherName in info.OtherMissileNames)
                    if (otherName == spellOrMissileName)
                        return info;
            }
            return null;
        }

        public static SpellInfo CreateInstancedSpellInfo(SpellInfo info)
        {
            if (info == null)
                return null;

            SpellInfo newSpellInstance = new SpellInfo();

            var type = typeof(SpellInfo);
            foreach (var sourceProperty in type.GetProperties().ToList())
            {
                var targetProperty = type.GetProperty(sourceProperty.Name);
                targetProperty.SetValue(newSpellInstance, sourceProperty.GetValue(info, null), null);
            }
            foreach (var sourceField in type.GetFields().ToList())
            {
                try
                {
                    var targetField = type.GetField(sourceField.Name);
                    targetField.SetValue(newSpellInstance, sourceField.GetValue(info));
                }
                catch
                {
                    Console.WriteLine("failed with field " + sourceField.Name);
                }
            }
            return newSpellInstance;
        }

        public static void Initialize()
        {
            List<string> ChampionNames = new List<string>();
            foreach (AIHeroClient hero in EntityManager.Heroes.AllHeroes)
                if (!ChampionNames.Contains(hero.ChampionName))
                    ChampionNames.Add(hero.ChampionName);

            foreach (SpellInfo spell in SpellInfoList.Where(a=>ChampionNames.Contains(a.ChampionName)))
                SpellList.Add(spell);
        }
    }
}
