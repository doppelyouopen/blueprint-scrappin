using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueprintScrappin.Util
{
    public static class BlueprintScrappinUtil
    {
        public static bool Truthy(object truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(object falsyable)
        {
            return
                falsyable == null ||
                falsyable.Equals("") ||
                (
                    falsyable is IComparable &&
                    (
                        (falsyable is System.Byte _System_Byte && Truthy(_System_Byte)) ||
                        (falsyable is System.SByte _System_SByte && Truthy(_System_SByte)) ||
                        (falsyable is System.UInt16 _System_UInt16 && Truthy(_System_UInt16)) ||
                        (falsyable is System.Int16 _System_Int16 && Truthy(_System_Int16)) ||
                        (falsyable is System.UInt32 _System_UInt32 && Truthy(_System_UInt32)) ||
                        (falsyable is System.Int32 _System_Int32 && Truthy(_System_Int32)) ||
                        (falsyable is System.UInt64 _System_UInt64 && Truthy(_System_UInt64)) ||
                        (falsyable is System.Int64 _System_Int64 && Truthy(_System_Int64)) ||
                        (falsyable is System.Single _System_Single && Truthy(_System_Single)) ||
                        (falsyable is System.Double _System_Double && Truthy(_System_Double)) ||
                        (falsyable is System.Decimal _System_Decimal && Truthy(_System_Decimal))
                    )
                );
        }


        public static bool Truthy(System.Byte truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.Byte falsyable)
        {
            return falsyable == 0;
        }

        public static bool Truthy(System.SByte truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.SByte falsyable)
        {
            return falsyable == 0;
        }

        public static bool Truthy(System.UInt16 truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.UInt16 falsyable)
        {
            return falsyable == 0;
        }

        public static bool Truthy(System.Int16 truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.Int16 falsyable)
        {
            return falsyable == 0;
        }

        public static bool Truthy(System.UInt32 truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.UInt32 falsyable)
        {
            return falsyable == 0;
        }

        public static bool Truthy(System.Int32 truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.Int32 falsyable)
        {
            return falsyable == 0;
        }

        public static bool Truthy(System.UInt64 truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.UInt64 falsyable)
        {
            return falsyable == 0;
        }

        public static bool Truthy(System.Int64 truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.Int64 falsyable)
        {
            return falsyable == 0;
        }

        public static bool Truthy(System.Single truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.Single falsyable)
        {
            return falsyable == 0 || float.IsNaN(falsyable);
        }

        public static bool Truthy(System.Double truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.Double falsyable)
        {
            return falsyable == 0 || double.IsNaN(falsyable);
        }

        public static bool Truthy(System.Decimal truthyable)
        {
            return !Falsy(truthyable);
        }

        public static bool Falsy(System.Decimal falsyable)
        {
            return falsyable == 0;
        }

        public static Blueprint Clone(Blueprint blueprint)
        {
            return 
                blueprint != null ?
                new Blueprint
                {
                    Description = Clone(blueprint.Description),
                    Object = Clone(blueprint.Object)
                }
                : null;
        }

        public static BlueprintDescription Clone(BlueprintDescription blueprintDescription)
        {
            return
                blueprintDescription != null ?
                new BlueprintDescription
                {
                    Description = blueprintDescription.Description,
                    LocalId = blueprintDescription.LocalId,
                    Name = blueprintDescription.Name,
                    Type = blueprintDescription.Type,
                    Version = blueprintDescription.Version
                }
                : null;
        }

        public static BlueprintObject Clone(BlueprintObject blueprintObject)
        {
            return
                blueprintObject != null ?
                new BlueprintObject
                {
                    Bodies = Clone(blueprintObject.Bodies),
                    Version = blueprintObject.Version
                }
                : null;
        }

        public static ICollection<BlueprintBody> Clone(ICollection<BlueprintBody> blueprintBodies)
        {
            return
                blueprintBodies != null ?
                blueprintBodies
                    .Select(bb => Clone(bb))
                    .ToList()
                : null;
        }

        public static BlueprintBody Clone(BlueprintBody blueprintBody)
        {
            return
                blueprintBody != null ?
                new BlueprintBody
                {
                    Childs = Clone(blueprintBody.Childs)
                }
                : null;
        }

        public static IEnumerable<BlueprintBodyChild> Clone(BlueprintBodyChild blueprintBodyChild, int count)
        {
            return Enumerable
                .Range(0, count)
                .Select(_=>Clone(blueprintBodyChild));
        }

        public static ICollection<BlueprintBodyChild> Clone(ICollection<BlueprintBodyChild> blueprintBodyChildren)
        {
            return
                blueprintBodyChildren != null ?
                blueprintBodyChildren
                    .Select(bbc => Clone(bbc))
                    .ToList()
                : null;
        }

        public static BlueprintBodyChild Clone(BlueprintBodyChild blueprintBodyChild)
        {
            return 
                blueprintBodyChild != null ?
                new BlueprintBodyChild
                {
                    Bounds = Clone(blueprintBodyChild.Bounds),
                    Color = blueprintBodyChild.Color,
                    Controller = Clone(blueprintBodyChild.Controller),
                    Pos = Clone(blueprintBodyChild.Pos),
                    ShapeId = blueprintBodyChild.ShapeId,
                    Xaxis = blueprintBodyChild.Xaxis,
                    Zaxis = blueprintBodyChild.Zaxis
                }
                : null;
        }

        public static ICollection<VectorI3> Clone(VectorI3 vectorI3, int count)
        {
            return
                Enumerable
                    .Range(0, count)
                    .Select(_ => Clone(vectorI3))
                    .ToList();
        }

        public static ICollection<VectorI3> Clone(ICollection<VectorI3> vectorI3s)
        {
            return
                vectorI3s != null ?
                vectorI3s
                    .Select(v => Clone(v))
                    .ToList()
                : null;
        }

        public static VectorI3 Clone(VectorI3 vectorI3)
        {
            return 
                vectorI3 != null ?
                new VectorI3
                {
                    X = vectorI3.X,
                    Y = vectorI3.Y,
                    Z = vectorI3.Z
                } 
                : null;
        }

        public static BlueprintController Clone(BlueprintController blueprintController)
        {
            return
                blueprintController != null ?
                new BlueprintController
                {
                    Active = blueprintController.Active,
                    AudioIndex = blueprintController.AudioIndex,
                    Controllers = Clone(blueprintController.Controllers),
                    Id = blueprintController.Id,
                    Joints = Clone(blueprintController.Joints),
                    Length = blueprintController.Length,
                    Mode = blueprintController.Mode,
                    Pitch = blueprintController.Pitch,
                    Speed = blueprintController.Speed,
                    StiffnessLevel = blueprintController.StiffnessLevel,
                    Volume = blueprintController.Volume
                }
                : null;
        }

        public static ICollection<BlueprintControllerReference> Clone(ICollection<BlueprintControllerReference> blueprintControllerReferences)
        {
            return
                blueprintControllerReferences != null ?
                blueprintControllerReferences
                    .Select(bcr => Clone(bcr))
                    .ToList()
                : null;
        }

        public static BlueprintControllerReference Clone(BlueprintControllerReference blueprintControllerReference)
        {
            return
                blueprintControllerReference != null ?
                new BlueprintControllerReference
                {
                    Id = blueprintControllerReference.Id
                }
                : null;
        }

        public static ICollection<BlueprintJointReference> Clone(ICollection<BlueprintJointReference> blueprintJointReferences)
        {
            return
                blueprintJointReferences != null ?
                blueprintJointReferences
                    .Select(bjr => Clone(bjr))
                    .ToList()
                : null;
        }

        public static BlueprintJointReference Clone(BlueprintJointReference blueprintJointReference)
        {
            return
                blueprintJointReference != null ?
                new BlueprintJointReference
                {
                    Id = blueprintJointReference.Id
                }
                : null;
        }

        public static int BodyCount(Blueprint blueprint)
        {
            return BodyCount(blueprint?.Object);
        }

        public static int BodyCount(BlueprintObject blueprintObject)
        {
            return blueprintObject?.Bodies?.Count() ?? 0;
        }

        public static int ChildrenCount(Blueprint blueprint)
        {
            return ChildrenCount(blueprint?.Object);
        }

        public static int ChildrenCount(BlueprintObject blueprintObject)
        {
            return ChildrenCount(blueprintObject?.Bodies);
        }

        public static int ChildrenCount(IEnumerable<BlueprintBody> blueprintBodies)
        {
            return blueprintBodies?.Select(ChildrenCount).Aggregate((a, b) => a + b) ?? 0;
        }

        public static int ChildrenCount(BlueprintBody blueprintBody)
        {
            return ChildrenCount(blueprintBody?.Childs);
        }
        
        public static int ChildrenCount(IEnumerable<BlueprintBodyChild> blueprintBodyChildren)
        {
            return blueprintBodyChildren?.Count() ?? 0;
        }

        public static int JointCount(Blueprint blueprint)
        {
            return 0;
        }
    }
}
