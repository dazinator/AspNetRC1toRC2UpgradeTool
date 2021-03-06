# AspNetSolutionUpgradeTool

This tool upgrades RC1, or RC2 solution, to RTM

If this tool has helped you upgrade your project, please consider leaving an entry on the wiki - https://github.com/dazinator/AspNetSolutionUpgradeTool/wiki/Usages


```

AspNetUpgrade.exe --solutionDir "E:\\path\\to\\your\\solution" -r RTM

```


1. Upgrades the `project.json` files, `.xproj` files, `launchSettings.json` files and  `global.json` file to the new schema's versions.
2. Upgrades `.cs` files, using Roslyn, to detect and replace old RC1 using statements. 
3. Upgrades dependencies (NuGet packages) and commands, to the appropriate RTM dependencies / tools. (lot's of renaming occured).

NOTE: This tool only does some simple C# code refactoring at present - i.e using statement rewrites, all the rest is still left to you, however as this tool has access to the full `SyntaxTree` it's fairly easy to add new analysis / refactorings into the tool if you know what you are doing with Roslyn ;)

This tool doesn't currently correct Razor files, i;m investigating that at the moment, see [#41](https://github.com/dazinator/AspNetRC1toRC2UpgradeTool/issues/41)

Your mileage may vary.

This tool is `Idempotent` - which means you should be able to run it against the solution multiple times in a row without negative consequences. As I add new enhancements to this tool, you could run it against a solution you upgraded previosuly with the tool, and this time you should get the enhanced behaviour applied.

# Thanks

A variety of sources have been used to build this tool, inlcuding my own trial and error. Some noteable mentions:

1. Shaun's blog: https://wildermuth.com/2016/05/17/Converting-an-ASP-NET-Core-RC1-Project-to-RC2
2. @Pranavkm's tool that does project.json schema changes: https://github.com/pranavkm/FixProjectJsonWarnings


