﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class ChakramArts : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111030032; } }
        public override string Name { get { return "Chakram Arts"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Thrown && ability.Formula == SchemaConstants.Formulas.Physical)
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
