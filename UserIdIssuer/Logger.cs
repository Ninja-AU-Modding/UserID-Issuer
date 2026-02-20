namespace UserIdIssuer;

public static class UserIdLogger
{
    public static void Debug(string message)
    {
        if (UserIdIssuerPlugin.IsDevRelease)
        {
            Logger<UserIdIssuerPlugin>.Debug(message);
        }
    }

    public static void Info(string message)
    {
        Logger<UserIdIssuerPlugin>.Info(message);
    }

    public static void Warn(string message)
    {
        Logger<UserIdIssuerPlugin>.Warning(message);
    }

    public static void Error(string message)
    {
        Logger<UserIdIssuerPlugin>.Error(message);
    }

    public static void Fatal(string message)
    {
        Logger<UserIdIssuerPlugin>.Fatal(message);
    }
}