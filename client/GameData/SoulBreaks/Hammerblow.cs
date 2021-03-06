﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Hammerblow : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20760003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BARRET; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.35; } }
        public override string Name { get { return "Hammerblow"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
