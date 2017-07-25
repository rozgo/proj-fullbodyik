// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class proj_fullbodyikTarget : TargetRules
{
	public proj_fullbodyikTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "proj_fullbodyik" } );
	}
}
