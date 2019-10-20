using System;

namespace BlueprintScrappin {
    public class BlueprintDescription 
    {
        public string Description { get; set; }
        public Guid LocalId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } = BlueprintTypes.Blueprint;
        public int Version { get; set; }
    }
}