using UnrealBuildTool;

public class SandsOfSetServerTarget : TargetRules
{
	public SandsOfSetServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SandsOfSet");
	}
}
