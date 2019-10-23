using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace BlueprintScrappin
{
    public static class Shapes
    {
        public static IShapeInformation ConcreteBlock { get; private set; } 
            = new ShapeInformation { 
                ShapeId = Guid.Parse("a6c6ce30-dd47-4587-b475-085d55c6a3b4"),
                PlacementType = ShapePlacementType.Block
            };
        public static IShapeInformation MetalBlock { get; private set; } 
            = new ShapeInformation { 
                ShapeId = Guid.Parse("8aedf6c2-94e1-4506-89d4-a0227c552f1e"),
                PlacementType = ShapePlacementType.Block
            };
        public static IShapeInformation Button { get; private set; }
            = new ShapeInformation { 
                ShapeId = Guid.Parse("8aedf6c2-94e1-4506-89d4-a0227c552f1e"),
                PlacementType = ShapePlacementType.Component,
                OutputMax = int.MaxValue
            };
        public static IShapeInformation LogicGate { get; private set; }
            = new ShapeInformation { 
                ShapeId = Guid.Parse("8aedf6c2-94e1-4506-89d4-a0227c552f1e"),
                PlacementType = ShapePlacementType.Component,
                HasActive = true,
                InputMax = int.MaxValue,
                OutputMax = int.MaxValue
            };
        public static IShapeInformation TotebotHeadBass { get; private set; }
            = new ShapeInformation { 
                ShapeId = Guid.Parse("161786c1-1290-4817-8f8b-7f80de755a06"),
                PlacementType = ShapePlacementType.Component,
                HasAudioIndex = true,
                HasPitch = true,
                HasVolume = true,
                InputMax = 1
            };
        public static IShapeInformation TotebotHeadPercussion { get; private set; } 
            = new ShapeInformation { 
                ShapeId = Guid.Parse("4c6e27a2-4c35-4df3-9794-5e206fef9012"),
                PlacementType = ShapePlacementType.Component,
                HasAudioIndex = true,
                HasPitch = true,
                HasVolume = true,
                InputMax = 1
            };
        public static IShapeInformation TotebotHeadSynthVoice { get; private set; } 
            = new ShapeInformation { 
                ShapeId = Guid.Parse("a052e116-f273-4d73-872c-924a97b86720"),
                PlacementType = ShapePlacementType.Component,
                HasAudioIndex = true,
                HasPitch = true,
                HasVolume = true,
                InputMax = 1
            };
        public static IShapeInformation TotebotHeadBlip { get; private set; } 
            = new ShapeInformation { 
                ShapeId = Guid.Parse("1c04327f-1de4-4b06-92a8-2c9b40e491aa"),
                PlacementType = ShapePlacementType.Component,
                HasAudioIndex = true,
                HasPitch = true,
                HasVolume = true,
                InputMax = 1
            };
        public static IShapeInformation Bearing { get; private set; } 
            = new ShapeInformation { 
                ShapeId = Guid.Parse("4a1b886b-913e-4aad-b5b6-6e41b0db23a6"),
                PlacementType = ShapePlacementType.Joint
            };
        public static IShapeInformation ShortSuspension { get; private set; } 
            = new ShapeInformation { 
                ShapeId = Guid.Parse("aa8d89eb-919b-42f4-8b58-af6f0d5856bc"),
                PlacementType = ShapePlacementType.Joint,
                HasStiffnessLevel = true
            };
        public static IShapeInformation OffRoadSuspension { get; private set; } 
            = new ShapeInformation { 
                ShapeId = Guid.Parse("a481138b-fae9-47c9-9bc2-91b6d2e2bf52"),
                PlacementType = ShapePlacementType.Joint,
                HasStiffnessLevel = true
            };
        public static IShapeInformation Piston { get; private set; } 
            = new ShapeInformation { 
                ShapeId = Guid.Parse("260b4597-f1ac-409c-8e6b-90c998c5fe94"),
                PlacementType = ShapePlacementType.Joint,
                HasLength = true,
                HasSpeed = true
            };
        public static IShapeInformation LargeExplosiveCanister { get; private set; } 
            = new ShapeInformation { 
                ShapeId = Guid.Parse("24001201-40dd-4950-b99f-17d878a9e07b"),
                PlacementType = ShapePlacementType.Component
            };

        public static ICollection<IShapeInformation> RegisteredShapes { get; private set; } = new HashSet<IShapeInformation>(new ShapeInformationComparer());

        static Shapes()
        {
            var shapes = 
                typeof(Shapes)
                    .GetProperties()
                    .Where(prop => typeof(IShapeInformation).IsAssignableFrom(prop.PropertyType))
                    .Select(prop =>prop.GetGetMethod().Invoke(null, null) as IShapeInformation);
            foreach (var shape in shapes)
            {
                RegisteredShapes.Add(shape);
            }
        }

        protected class ShapeInformationComparer : IEqualityComparer<IShapeInformation>
        {
            public bool Equals([AllowNull] IShapeInformation x, [AllowNull] IShapeInformation y)
            {
                return x?.ShapeId.Equals(y?.ShapeId) == true;
            }

            public int GetHashCode([DisallowNull] IShapeInformation obj)
            {
                return obj?.ShapeId.GetHashCode() ?? 0;
            }
        }

        protected class ShapeInformation : IShapeInformation
        {
            public Guid ShapeId { get; set; }

            public bool HasActive { get; set; }

            public ShapePlacementType PlacementType { get; set; }

            public int InputMax { get; set; }

            public int OutputMax { get; set; }

            public bool HasAudioIndex { get; set; }

            public bool HasLength { get; set; }

            public bool HasPitch { get; set; }

            public bool HasVolume { get; set; }

            public bool HasSpeed { get; set; }

            public bool HasStiffnessLevel { get; set; }

            public bool HasMode { get; set; }
        }
    }
}
