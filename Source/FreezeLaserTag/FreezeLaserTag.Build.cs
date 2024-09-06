// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FreezeLaserTag : ModuleRules
{
	public FreezeLaserTag(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
