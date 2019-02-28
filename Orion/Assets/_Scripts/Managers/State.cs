/// <summary>
/// Keeper of the local game's state.
/// Used to determine side-specific functions and the UI.
/// </summary>

public static class State {
    public static GameStates state;
}

public enum GameStates {
    NONE,
    Stealth,
    Seeker,
    Death,
    Pause
}