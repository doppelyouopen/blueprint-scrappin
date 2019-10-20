using System;

namespace BlueprintScrappin 
{
    public interface IBlueprintLoader 
    {
	    Blueprint LoadBlueprint(Guid objectId);
    }
}