using UnrealBuildTool;

public class SandsOfSetTarget : TargetRules
{
	public SandsOfSetTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SandsOfSet");
	}
}
