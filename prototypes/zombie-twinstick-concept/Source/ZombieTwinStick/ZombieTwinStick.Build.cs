// PROTOTYPE - NOT FOR PRODUCTION
// Question: Does dual touch-stick control feel satisfying on a phone?
// Date: 2026-11-23

using UnrealBuildTool;

public class ZombieTwinStick : ModuleRules
{
	public ZombieTwinStick(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
