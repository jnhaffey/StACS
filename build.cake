#tool nuget:?package=xunit.runner.console
#addin nuget:?package=Cake.Git
//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

// Define project names
var coreProjectName = "StACS.Core";
var netFxExtensionsProjectName = "StACS.NetFx.Extensions";
var netFxFunctionsProjectName = "StACS.NetFx.Functions";

// Define project file names
var coreFileName = File(coreProjectName.ToString() + ".csproj");
var netFxExtensionsFileName = File(netFxExtensionsProjectName.ToString() + ".csproj");
var netFxFunctionsFileName = File(netFxExtensionsProjectName.ToString() + ".csproj");

// Define directories
var srcDir = Directory("./src");
var testDir = Directory("./test");

var coreProjectDir = Directory(srcDir) + Directory(coreProjectName);
var coreProjectBuildDir = Directory(coreProjectDir) + Directory("bin") + Directory(configuration);

var netFxExtensionProjectDir = Directory(srcDir) + Directory(netFxExtensionsProjectName);
var netFxExtensionBuildDir = Directory(netFxExtensionProjectDir) + Directory("bin") + Directory(configuration);

var netFxFunctionsProjectDir = Directory(srcDir) + Directory(netFxFunctionsProjectName);
var netFxFunctionsBuildDir = Directory(netFxFunctionsProjectDir) + Directory("bin") + Directory(configuration);

// Global Variables
var coreProjectHasChanges = false;
var netFxExtensionsProjectHasChanges = false;
var netFxFunctionsProjectHasChanges = false;

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("DisplayAllVariable")
	.WithCriteria(configuration == "Debug")
	.Does(() =>
{
	Information("srcDir: {0}\r\ntestDir: {1}\r\n", 
		srcDir, testDir);
	Information("coreProjectName: {0}\r\ncoreFileName: {1}\r\ncoreProjectDir: {2}\r\ncoreProjectBuildDir: {3}\r\n", 
		coreProjectName, coreFileName, coreProjectDir, coreProjectBuildDir);
	Information("netFxExtensionsProjectName: {0}\r\nnetFxExtensionsFileName: {1}\r\nnetFxExtensionProjectDir: {2}\r\nnetFxExtensionBuildDir: {3}\r\n", 
		netFxExtensionsProjectName, netFxExtensionsFileName, netFxExtensionProjectDir, netFxExtensionBuildDir);
	Information("netFxFunctionsProjectName: {0}\r\nnetFxFunctionsFileName: {1}\r\nnetFxFunctionsProjectDir: {2}\r\nnetFxFunctionsBuildDir: {3}\r\n", 
		netFxFunctionsProjectName, netFxFunctionsFileName, netFxFunctionsProjectDir, netFxFunctionsBuildDir);
});

Task("Clean")
	.IsDependentOn("DisplayAllVariable")
    .Does(() =>
{
    CleanDirectory(coreProjectBuildDir);
	CleanDirectory(netFxExtensionBuildDir);
	CleanDirectory(netFxFunctionsBuildDir);
});

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore("./StACS.sln");
});

Task("Check-Project-Git-Status")
	.IsDependentOn("Restore-NuGet-Packages")
	.Does(() =>
{
	//coreProjectHasChanges = GitHasUncommitedChanges(coreProjectDir);
	Information("Looking at: {0}", coreProjectDir);
	var result = GitDiff(coreProjectDir);
	Information("GitDiff: {0}", result);
	
});

Task("Build-Core")
    .IsDependentOn("Check-Project-Git-Status")
	.WithCriteria(coreProjectHasChanges == true)
    .Does(() =>
{
      // Use MSBuild
	  var projectFile = Directory(coreProjectDir) + File(coreProjectName + ".csproj");
      MSBuild(projectFile, settings => settings.SetConfiguration(configuration));
});

Task("Run-Unit-Tests")
    .IsDependentOn("Build-Core")
    .Does(() =>
{
    NUnit3(testDir.ToString() + "/**/bin/" + configuration + "**/*.Tests.dll", new NUnit3Settings {
        NoResults = true
        });
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Run-Unit-Tests");

Task("Test")
	.IsDependentOn("Check-Project-Git-Status");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);