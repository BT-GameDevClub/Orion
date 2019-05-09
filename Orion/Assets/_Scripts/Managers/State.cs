/// <summary>
/// Keeper of the local game's state.
/// Used to determine side-specific functions and the UI.
/// </summary>

public static class State
{
    public static GameStates gameState;
    public static PlayStates playState;
}

public enum GameStates
{
    NONE,
    Stealth,
    Seeker,
    Death,
}

public enum PlayStates
{
    NONE,
    InGame,
    Paused
}