using UnrealBuildTool;

public class SandsOfSetEditorTarget : TargetRules
{
	public SandsOfSetEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SandsOfSet");
	}
}
