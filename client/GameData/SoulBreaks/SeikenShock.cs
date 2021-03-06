﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SeikenShock : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22050004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BEATRIX; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.95; } }
        public override string Name { get { return "Seiken Shock"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
