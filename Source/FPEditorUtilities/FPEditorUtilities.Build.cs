// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FPEditorUtilities : ModuleRules
{
	public FPEditorUtilities(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
			});

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",

				"GameplayAbilities",
				"GameplayAbilitiesEditor",
				"UnrealEd",
				"Blutility",
				"AssetTools",
				"CurveTableEditor",
				"HTTP",
				"ToolMenus",
				"UnrealEd",
				"GameplayTags",

				// Object table
				"WorkspaceMenuStructure",
				"EditorScriptingUtilities",
				"EditorWidgets",
				"InputCore",
			});
	}
}