﻿using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace Holsters.Settings.Drawing.Tabs.Equipment
{
    internal static class SelectedEquipmentTracker 
    {
        private static readonly List<ThingDef> _selectedEquipment = new List<ThingDef>();

        public static List<ThingDef> SelectedEquipment => _selectedEquipment;

        public static void UpdateSelection(ThingDef equipment)
        {
            _selectedEquipment.Clear();
            _selectedEquipment.Add(equipment);
        }
    }
}