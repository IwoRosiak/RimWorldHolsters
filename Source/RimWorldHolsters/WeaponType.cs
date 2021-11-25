﻿using Verse;

namespace RimWorldHolsters
{
    [StaticConstructorOnStartup]
    public static class IR_WeaponType
    {
        public static WeaponType EstablishWeaponType(ThingWithComps weapon)
        {
            return EstablishWeaponType(weapon.def);
        }

        public static WeaponType EstablishWeaponType(ThingDef weapon)
        {
            if (weapon.IsRangedWeapon)
            {
                if (weapon.defName.StartsWith("Bow_"))
                {
                    return WeaponType.bow;
                }
                if (weapon.Verbs[0].CausesExplosion)
                {
                    return WeaponType.grenades;
                }
                if (weapon.uiIconScale != 1)
                {
                    return WeaponType.shortRanged;
                }
                return WeaponType.longRanged;
            }
            if (weapon.IsMeleeWeapon)
            {
                if (weapon.uiIconScale != 1)
                {
                    return WeaponType.shortMelee;
                }
                return WeaponType.longMelee;
            }
            return WeaponType.grenades;
        }

        public static bool EstablishWeaponSize(ThingWithComps weapon)
        {
            switch (EstablishWeaponType(weapon))
            {
                case WeaponType.longRanged:
                case WeaponType.longMelee:
                case WeaponType.bow:
                    return true;
                    break;

                case WeaponType.shortMelee:
                case WeaponType.shortRanged:
                    return false;
                    break;
            }
            return false;
        }
    }
}