﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Gauntlet : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22040005; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.YUFFIE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2; } }
        public override string Name { get { return "Gauntlet"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
