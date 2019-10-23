using System;
using System.Collections.Generic;
using System.Text;

namespace BlueprintScrappin.Util.Extensions
{
    public static class BlueprintScrappinUtilExtensions
    {
        public static bool Truthy(this System.Object truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.Object falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.Boolean truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.Boolean falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.Byte truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.Byte falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.SByte truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.SByte falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.UInt16 truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.UInt16 falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.Int16 truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.Int16 falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.UInt32 truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.UInt32 falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.Int32 truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.Int32 falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.UInt64 truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.UInt64 falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.Int64 truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.Int64 falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.Single truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.Single falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.Double truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.Double falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static bool Truthy(this System.Decimal truthyable)
        {
            return BlueprintScrappinUtil.Truthy(truthyable);
        }

        public static bool Falsy(this System.Decimal falsyable)
        {
            return BlueprintScrappinUtil.Falsy(falsyable);
        }

        public static Blueprint Clone(Blueprint blueprint)
        {
            return BlueprintScrappinUtil.Clone(blueprint);
        }

        public static BlueprintDescription Clone(this BlueprintDescription blueprintDescription)
        {
            return BlueprintScrappinUtil.Clone(blueprintDescription);
        }

        public static BlueprintObject Clone(this BlueprintObject blueprintObject)
        {
            return BlueprintScrappinUtil.Clone(blueprintObject);
        }

        public static ICollection<BlueprintBody> Clone(this ICollection<BlueprintBody> blueprintBodies)
        {
            return BlueprintScrappinUtil.Clone(blueprintBodies);
        }

        public static BlueprintBody Clone(this BlueprintBody blueprintBody)
        {
            return BlueprintScrappinUtil.Clone(blueprintBody);
        }

        public static IEnumerable<BlueprintBodyChild> Clone(this BlueprintBodyChild blueprintBodyChild, int count)
        {
            return BlueprintScrappinUtil.Clone(blueprintBodyChild, count);
        }

        public static ICollection<BlueprintBodyChild> Clone(this ICollection<BlueprintBodyChild> blueprintBodyChildren)
        {
            return BlueprintScrappinUtil.Clone(blueprintBodyChildren);
        }

        public static BlueprintBodyChild Clone(this BlueprintBodyChild blueprintBodyChild)
        {
            return BlueprintScrappinUtil.Clone(blueprintBodyChild);
        }

        public static ICollection<VectorI3> Clone(this VectorI3 vectorI3, int count)
        {
            return BlueprintScrappinUtil.Clone(vectorI3, count);
        }

        public static ICollection<VectorI3> Clone(this ICollection<VectorI3> vectorI3s)
        {
            return BlueprintScrappinUtil.Clone(vectorI3s);
        }

        public static VectorI3 Clone(this VectorI3 vectorI3)
        {
            return BlueprintScrappinUtil.Clone(vectorI3);
        }

        public static BlueprintController Clone(this BlueprintController blueprintController)
        {
            return BlueprintScrappinUtil.Clone(blueprintController);
        }

        public static ICollection<BlueprintControllerReference> Clone(this ICollection<BlueprintControllerReference> blueprintControllerReferences)
        {
            return BlueprintScrappinUtil.Clone(blueprintControllerReferences);
        }

        public static BlueprintControllerReference Clone(this BlueprintControllerReference blueprintControllerReference)
        {
            return BlueprintScrappinUtil.Clone(blueprintControllerReference);
        }

        public static ICollection<BlueprintJointReference> Clone(this ICollection<BlueprintJointReference> blueprintJointReferences)
        {
            return BlueprintScrappinUtil.Clone(blueprintJointReferences);
        }

        public static BlueprintJointReference Clone(this BlueprintJointReference blueprintJointReference)
        {
            return BlueprintScrappinUtil.Clone(blueprintJointReference);
        }

        public static int BodyCount(this Blueprint blueprint)
        {
            return BlueprintScrappinUtil.BodyCount(blueprint);
        }

        public static int BodyCount(this BlueprintObject blueprintObject)
        {
            return BlueprintScrappinUtil.BodyCount(blueprintObject);
        }

        public static int ChildrenCount(this Blueprint blueprint)
        {
            return BlueprintScrappinUtil.ChildrenCount(blueprint);
        }

        public static int ChildrenCount(this BlueprintObject blueprintObject)
        {
            return BlueprintScrappinUtil.ChildrenCount(blueprintObject);
        }

        public static int ChildrenCount(this IEnumerable<BlueprintBody> blueprintBodies)
        {
            return BlueprintScrappinUtil.ChildrenCount(blueprintBodies);
        }

        public static int ChildrenCount(this BlueprintBody blueprintBody)
        {
            return BlueprintScrappinUtil.ChildrenCount(blueprintBody);
        }

        public static int ChildrenCount(this IEnumerable<BlueprintBodyChild> blueprintBodyChildren)
        {
            return BlueprintScrappinUtil.ChildrenCount(blueprintBodyChildren);
        }
    }
}
