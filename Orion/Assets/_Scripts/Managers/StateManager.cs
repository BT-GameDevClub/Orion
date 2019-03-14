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

    public void ChangeState(GameStates _state) {
        State.state = _state;
        UI.UpdateUI();
    }
}
