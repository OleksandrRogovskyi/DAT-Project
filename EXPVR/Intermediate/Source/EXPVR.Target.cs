using UnrealBuildTool;

public class EXPVRTarget : TargetRules
{
	public EXPVRTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("EXPVR");
	}
}
