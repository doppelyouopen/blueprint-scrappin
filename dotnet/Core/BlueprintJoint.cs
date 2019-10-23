using System;

namespace BlueprintScrappin 
{
    public class BlueprintJoint
    {
        /// <summary>
        /// nth index of source body in bodies
        /// </summary>
        /// <value></value>
        public int ChildA { get; set; }

        /// <summary>
        /// nth index of target body in bodies
        /// </summary>
        /// <value></value>
        public int ChildB { get; set; }
        public string Color { get; set; }
        public BlueprintController Controller { get; set; }
        public int Id { get; set; }
        public VectorI3 PosA { get; set; }
        public VectorI3 PosB { get; set; }
        public Guid ShapeId { get; set; }
        public int XaxisA { get; set; }
        public int XaxisB { get; set; }
        public int ZAxisA { get; set; }
        public int ZaxisB { get; set; }
    }
}