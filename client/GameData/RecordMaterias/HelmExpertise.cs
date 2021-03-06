﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class HelmExpertise : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111000220; } }
        public override string Name { get { return "Helm Expertise"; } }

        public override double DefModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (armor != null && armor.Category == SchemaConstants.EquipmentCategory.Helm)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
