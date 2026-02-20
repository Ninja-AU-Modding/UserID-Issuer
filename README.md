<div id="toc">
  <ul align="center" style="list-style: none">
   <summary>
      <h1 align="center">
        UserID Issuer &nbsp;
        <img src="https://raw.githubusercontent.com/Ninja-AU-Modding/UserID-Issuer/refs/heads/main/UserIdIssuer/icon.png" width="5%" alt="Logo" />
      </h1>
   </summary>
  </ul>
</div>

> [!NOTE]
> This mod depends on [Reactor](https://github.com/NuclearPowered/Reactor)

This mod mainly exists to ensure compatability across the places Among Us is availible (Epic, Steam, Itch, etc)

This mod generates every user a unique UserID which can then be accessed by other mods.

> [!NOTE]
> Notable mods this is used in: AUSummary, Goober's TOU:M Ranked

## Code example (if you're using this in your own mod)
```csharp
using static UserIdIssuer.Utils;

const string userId = getUserId();
```

## Self-compiling (if you're paranoid this is some sort of virus)
Use [Cake](https://cakebuild.net/docs/running-builds/runners/dotnet-tool)

```bash
dotnet cake --target="Build"
```
