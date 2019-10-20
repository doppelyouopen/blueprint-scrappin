using System;

namespace BlueprintScrappin {
    public class BlueprintBodyChild {
	public VectorI3 Bounds { get; set; }
	public string Color { get; set; }
	public BlueprintController Controller { get; set; }
	public VectorI3 Pos { get; set;}
	public Guid ShapeId { get; set; }
	public int Xaxis { get; set; }
	public int Zaxis { get; set; }
}
}