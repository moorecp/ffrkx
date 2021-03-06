﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class LeafSwirl : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 21000048; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.MOG; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.1; } }
        public override string Name { get { return "Leaf Swirl"; } }
    }
}
