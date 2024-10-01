using UnityEngine;

public static class Settings
{
    public enum Language
    {
        RUS = 1,
        ENG = 2,
        TUR = 4
    }
    public static bool IsSound = true;
    public static bool IsStop { get; set; } = false;
    public static int SpawnTime = 5;
    public static string NameLeaderBoard => "DayLeaderBoardSurvived";
    public static KeyCode KeySprint => KeyCode.LeftShift;
    public static KeyCode KeyUse => KeyCode.E;
    public static KeyCode KeyEcs => KeyCode.Escape;
    public static Language CurrentLanguage { get; set; } = Language.RUS;
}