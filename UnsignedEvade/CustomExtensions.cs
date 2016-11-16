﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;

namespace UnsignedEvade
{
    static class CustomExtensions
    {
        public static bool IsOffCooldown(this SpellInfo info)
        {
            /*if (info.ChampionName == "Rengar")
            {
                if (info.SpellName != info.GetChampionSpell().Name)
                    return false;
            }
            */
            //empowered abilities -  Rengar
            if (info.ChampionName == "Rengar" && info.GetChampionSpell() != null && info.SpellName.Contains("Emp"))
                return true;
            
            if (info.GetChampionSpell() != null &&
                info.startingAmmoCount != -1)
                return true;

            return info.GetChampionSpell() != null && (!info.IsOnCooldown() || (info.BuffName != "" && info.caster.HasBuff(info.BuffName)));// && info.SpellName == info.GetChampionSpell().Name;
        }
        public static bool IsOnCooldown(this SpellInfo info)
        {
            return info.GetChampionSpell() != null && (Game.Time - info.GetChampionSpell().CooldownExpires) < 0;
        }
    }
}
