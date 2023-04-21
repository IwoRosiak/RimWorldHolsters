﻿using SettingsDrawer.Sections;
using UnityEngine;
using Verse;

namespace Holsters.Utility.ModSettings.Settings_Drawing.ModSettingsUtilitie.Operations
{
    internal class TextEntry : Operation
    {
        private string _label;

        private string _fieldText;

        public TextEntry(Rect area, string label, string name) : base(area)
        {
            _label = label;
            _fieldText = name;
        }

        public override void ExecuteOperation()
        {
            _fieldText = Widgets.TextEntryLabeled(area, _label, _fieldText);
        }

        public string GetFieldText()
        {
            return _fieldText;
        }

        
    }
}
