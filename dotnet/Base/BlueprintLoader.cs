using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;

namespace BlueprintScrappin
{
    public class BlueprintLoader : IBlueprintLoader
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

        public BlueprintLoader(string blueprintsRoot)
        {
            if (blueprintsRoot == null)
            {
                throw new ArgumentNullException($@"{nameof(BlueprintLoader)}(string {nameof(blueprintsRoot)})");
            }
            this.blueprintsRoot = blueprintsRoot;
        }

        public Blueprint LoadBlueprint(Guid objectId)
        {
            return new Blueprint
            {
                Description = JsonConvert.DeserializeObject<BlueprintDescription>(File.ReadAllText(Path.Combine(this.blueprintsRoot, objectId.ToString(), BlueprintDescriptionFileName))),
                Object = JsonConvert.DeserializeObject<BlueprintObject>(File.ReadAllText(Path.Combine(this.blueprintsRoot, objectId.ToString(), BlueprintObjectFileName)))
            };
        }
    }
}
