﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class SoldierStrike : RecordMateria
    {
        public override uint RecordMaterId { get { return 111070010; } }
        public override string Name { get { return "SOLDIER Strike"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon.Category == SchemaConstants.EquipmentCategory.Sword && ability.Formula == SchemaConstants.Formulas.Physical)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
