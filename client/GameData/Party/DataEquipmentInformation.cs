﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Party
{
    class DataEquipmentInformation
    {
        [JsonProperty("id")]
        public uint InstanceId;

        [JsonProperty("equipment_id")]
        public uint EquipmentId;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("evolution_num")]
        public byte EvolutionNumber;

        [JsonProperty("level")]
        public byte Level;

        [JsonProperty("level_max")]
        public byte LevelMax;

        [JsonProperty("rarity")]
        public SchemaConstants.Rarity Rarity;

        [JsonProperty("base_rarity")]
        public SchemaConstants.Rarity BaseRarity;

        [JsonProperty("series_id")]
        public uint SeriesId;

        [JsonProperty("equipment_type")]
        public SchemaConstants.ItemType Type;

        [JsonProperty("category_id")]
        public SchemaConstants.EquipmentCategory Category;
    }
}
