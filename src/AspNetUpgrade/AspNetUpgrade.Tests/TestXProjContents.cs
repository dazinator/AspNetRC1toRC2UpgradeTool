﻿namespace AspNetUpgrade.Tests
{
    public static class TestXProjContents
    {
        public const string LibraryApplication =
            "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Project ToolsVersion=\"14.0\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">\r\n  <PropertyGroup>\r\n    <VisualStudioVersion Condition=\"'$(VisualStudioVersion)' == ''\">14.0</VisualStudioVersion>\r\n    <VSToolsPath Condition=\"'$(VSToolsPath)' == ''\">$(MSBuildExtensionsPath32)\\Microsoft\\VisualStudio\\v$(VisualStudioVersion)</VSToolsPath>\r\n  </PropertyGroup>\r\n  <Import Project=\"$(VSToolsPath)\\DNX\\Microsoft.DNX.Props\" Condition=\"'$(VSToolsPath)' != ''\" />\r\n  <PropertyGroup Label=\"Globals\">\r\n    <ProjectGuid>cf17b32b-511b-4492-a4e4-a0222be72999</ProjectGuid>\r\n    <RootNamespace>Gluon.Core</RootNamespace>\r\n    <BaseIntermediateOutputPath Condition=\"'$(BaseIntermediateOutputPath)'=='' \">..\\..\\artifacts\\obj\\$(MSBuildProjectName)</BaseIntermediateOutputPath>\r\n    <OutputPath Condition=\"'$(OutputPath)'=='' \">..\\..\\artifacts\\bin\\$(MSBuildProjectName)\\</OutputPath>\r\n  </PropertyGroup>\r\n  <PropertyGroup>\r\n    <SchemaVersion>2.0</SchemaVersion>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Debug|AnyCPU'\">\r\n    <ProduceOutputsOnBuild>True</ProduceOutputsOnBuild>\r\n  </PropertyGroup>\r\n  <Import Project=\"$(VSToolsPath)\\DNX\\Microsoft.DNX.targets\" Condition=\"'$(VSToolsPath)' != ''\" />\r\n</Project>";

        public const string WebApplication =
            "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Project ToolsVersion=\"14.0\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">\r\n  <PropertyGroup>\r\n    <VisualStudioVersion Condition=\"'$(VisualStudioVersion)' == ''\">14.0</VisualStudioVersion>\r\n    <VSToolsPath Condition=\"'$(VSToolsPath)' == ''\">$(MSBuildExtensionsPath32)\\Microsoft\\VisualStudio\\v$(VisualStudioVersion)</VSToolsPath>\r\n  </PropertyGroup>\r\n  <Import Project=\"$(VSToolsPath)\\DNX\\Microsoft.DNX.Props\" Condition=\"'$(VSToolsPath)' != ''\" />\r\n  <PropertyGroup Label=\"Globals\">\r\n    <ProjectGuid>383226b6-9abc-407b-964a-33e0c3ca9534</ProjectGuid>\r\n    <RootNamespace>Reach.GCv3.Mvc.WebApplication</RootNamespace>\r\n    <BaseIntermediateOutputPath Condition=\"'$(BaseIntermediateOutputPath)'=='' \">..\\..\\artifacts\\obj\\$(MSBuildProjectName)</BaseIntermediateOutputPath>\r\n    <OutputPath Condition=\"'$(OutputPath)'=='' \">..\\..\\artifacts\\bin\\$(MSBuildProjectName)\\</OutputPath>\r\n  </PropertyGroup>\r\n  <PropertyGroup>\r\n    <SchemaVersion>2.0</SchemaVersion>\r\n    <DevelopmentServerPort>57475</DevelopmentServerPort>\r\n    <ApplicationInsightsResourceId>/subscriptions/5d58c857-6e75-40f4-b1c0-457b5bc84e42/resourcegroups/GC3/providers/microsoft.insights/components/GC3 Local</ApplicationInsightsResourceId>\r\n  </PropertyGroup>\r\n  <ItemGroup>\r\n    <DnxInvisibleContent Include=\"bower.json\" />\r\n    <DnxInvisibleContent Include=\".bowerrc\" />\r\n    <DnxInvisibleContent Include=\"package.json\" />\r\n  </ItemGroup>\r\n  <ItemGroup>\r\n    <Service Include=\"{82a7f48d-3b50-4b1e-b82e-3ada8210c358}\" />\r\n  </ItemGroup>\r\n  <ItemGroup>\r\n    <DnxInvisibleFolder Include=\"Decompiled\\\" />\r\n    <DnxInvisibleFolder Include=\"Modules\\\" />\r\n    <DnxInvisibleFolder Include=\"Shadowed\\\" />\r\n  </ItemGroup>\r\n  <Import Project=\"$(VSToolsPath)\\DNX\\Microsoft.DNX.targets\" Condition=\"'$(VSToolsPath)' != ''\" />\r\n</Project>";

    }
}