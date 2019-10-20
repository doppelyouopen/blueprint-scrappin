using System.Collections.Generic;

namespace BlueprintScrappin {
    public class BlueprintObject {
	public ICollection<BlueprintBody> Bodies { get; set; }
	public int Version { get; set; } = 3;
}
}