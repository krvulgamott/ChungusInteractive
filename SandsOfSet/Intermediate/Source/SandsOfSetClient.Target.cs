using UnrealBuildTool;

public class SandsOfSetClientTarget : TargetRules
{
	public SandsOfSetClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SandsOfSet");
	}
}
