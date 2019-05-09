using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the changing of States of the main player
/// </summary>

public class StateManager : MonoBehaviour
{
    // <-- Managers --> //
    public UIManager UI;

    // TEMPORARY
    public PlayStates playState;
    public GameStates gameState;

    public void ChangeGameState(GameStates _state) {
        State.gameState = _state;
        UI.UpdateUI();
    }
    public void ChangePlayState(PlayStates _state)
    {
        State.playState = _state;
        UI.UpdateUI();
    }

    // TEMP
    public void Update() {
        ChangeGameState(gameState);
        ChangePlayState(playState);
    }


}
