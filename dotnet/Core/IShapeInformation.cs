using System;
using System.Collections.Generic;
using System.Text;

namespace BlueprintScrappin
{
    public interface IShapeInformation
    {
        Guid ShapeId { get; }
        bool HasActive { get; }
        ShapePlacementType PlacementType { get; }
        int InputMax { get; }
        int OutputMax { get; }
        bool HasAudioIndex { get; }
        bool HasLength { get; }
        bool HasPitch { get; }
        bool HasVolume { get; }
        bool HasSpeed { get; }
        bool HasStiffnessLevel { get; }
        bool HasMode { get; }
    }
}
