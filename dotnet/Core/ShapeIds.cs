using System;

namespace BlueprintScrappin 
{
    public static class ShapeIds 
    {
        private static Guid? concreteBlock;
        public static Guid ConcreteBlock => concreteBlock ?? (Guid)(concreteBlock = Guid.Parse("a6c6ce30-dd47-4587-b475-085d55c6a3b4"));

        private static Guid? metalBlock;
        public static Guid MetalBlock => metalBlock ?? (Guid)(metalBlock = Guid.Parse ("8aedf6c2-94e1-4506-89d4-a0227c552f1e"));

        private static Guid? button;
        public static Guid Button => button ?? (Guid)(button = Guid.Parse ("8aedf6c2-94e1-4506-89d4-a0227c552f1e"));

        private static Guid? logicGate;
        public static Guid LogicGate => logicGate ?? (Guid)(logicGate = Guid.Parse ("8aedf6c2-94e1-4506-89d4-a0227c552f1e"));

        private static Guid? totebotHeadBass;
        public static Guid TotebotHeadBass => totebotHeadBass ?? (Guid)(totebotHeadBass = Guid.Parse("161786c1-1290-4817-8f8b-7f80de755a06"));

        private static Guid? totebotHeadPercussion;
        public static Guid TotebotHeadPercussion => totebotHeadPercussion ?? (Guid)(totebotHeadPercussion = Guid.Parse("4c6e27a2-4c35-4df3-9794-5e206fef9012"));

        private static Guid? totebotHeadSynthVoice;
        public static Guid TotebotHeadSynthVoice => totebotHeadSynthVoice ?? (Guid)(totebotHeadSynthVoice = Guid.Parse("a052e116-f273-4d73-872c-924a97b86720"));

        private static Guid? totebotHeadBlip;
        public static Guid TotebotHeadBlip => totebotHeadBlip ?? (Guid)(totebotHeadBlip = Guid.Parse ("1c04327f-1de4-4b06-92a8-2c9b40e491aa"));

        private static Guid? bearing;
        public static Guid Bearing => bearing ?? (Guid)(bearing = Guid.Parse("4a1b886b-913e-4aad-b5b6-6e41b0db23a6"));

        private static Guid? shortSuspension;
        public static Guid ShortSuspension => shortSuspension ?? (Guid)(shortSuspension = Guid.Parse("aa8d89eb-919b-42f4-8b58-af6f0d5856bc"));

        private static Guid? offRoadSuspension;
        public static Guid OffRoadSuspension => offRoadSuspension ?? (Guid)(offRoadSuspension = Guid.Parse("a481138b-fae9-47c9-9bc2-91b6d2e2bf52"));

        private static Guid? piston;
        public static Guid Piston => piston ?? (Guid)(piston = Guid.Parse("260b4597-f1ac-409c-8e6b-90c998c5fe94"));

        private static Guid? largeExplosiveCanister;
        public static Guid LargeExplosiveCanister => largeExplosiveCanister ?? (Guid)(largeExplosiveCanister = Guid.Parse("24001201-40dd-4950-b99f-17d878a9e07b"));
    }
}