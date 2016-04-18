﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class ArcherInWhite : RecordMateria
    {
        public override uint RecordMaterId { get { return 111040060; } }
        public override string Name { get { return "Archer in White"; } }

        public override double MndModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (weapon.Category == SchemaConstants.EquipmentCategory.Bow)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
