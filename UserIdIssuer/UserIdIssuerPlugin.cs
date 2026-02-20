using BepInEx;
using BepInEx.Unity.IL2CPP;
using Reactor;
using Reactor.Networking.Attributes;
using static UserIdIssuer.Utils;

namespace UserIdIssuer;

[BepInPlugin(Id, "UserIdIssuer", VersionString)]
[BepInDependency(ReactorPlugin.Id)]
[BepInProcess("Among Us.exe")]
[ReactorModFlags(Reactor.Networking.ModFlags.None)]
public partial class UserIdIssuerPlugin : BasePlugin
{
    public const string Id = "com.naum.useridissuer";
    public const string VersionString = "1.0.0";

    public static Version Version = Version.Parse(VersionString);

    /////////////////////
    public const bool IsDevRelease = false;
    /////////////////////

    public override void Load()
    {
        UserIdLogger.Debug("UID Issuer is loading...");

        ReactorCredits.Register(
            "UserIdIssuer",
            VersionString + (IsDevRelease ? "-indev" : ""),
            false,
            ReactorCredits.AlwaysShow
        );

        try
        {
            if (checkForId() == false)
            {
                IssueUserId();
            }
            if (IsDevRelease)
            {
                UserIdLogger.Info($"User ID: {getUserId()}");
            }
        }
        catch (Exception exception)
        {
            UserIdLogger.Error(
                $"An error occurred while loading UserIdIssuer-{VersionString + (IsDevRelease ? "-indev" : "")} ({Id})"
            );
            UserIdLogger.Error(exception.Message);
        }

        UserIdLogger.Info("UserIdIssuer finished loading");
    }
}