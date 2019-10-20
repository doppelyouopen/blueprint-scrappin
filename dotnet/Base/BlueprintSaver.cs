using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BlueprintScrappin
{
    public class BlueprintSaver : IBlueprintSaver
    {
        public const string BlueprintDescriptionFileName = @"description.json";
        public const string BlueprintObjectFileName = @"blueprint.json";
        private readonly string blueprintsRoot;
        private readonly JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };

        public BlueprintSaver(string blueprintsRoot)
        {
            this.blueprintsRoot = blueprintsRoot;
        }

        public void SaveBlueprint(Blueprint blueprint)
        {
            File.WriteAllText(Path.Combine(this.blueprintsRoot, blueprint.Description.LocalId.ToString(), BlueprintDescriptionFileName), JsonConvert.SerializeObject(blueprint.Description, serializerSettings));
            File.WriteAllText(Path.Combine(this.blueprintsRoot, blueprint.Description.LocalId.ToString(), BlueprintObjectFileName), JsonConvert.SerializeObject(blueprint.Object, serializerSettings));
        }
    }
}
