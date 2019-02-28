using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI manager
/// </summary>

public class UIManager : MonoBehaviour
{
    // <-- UIs --> //
    [Header("State UIs")]
    public GameObject None;
    public GameObject Stealth;
    public GameObject Seeker;
    public GameObject Death;
    public GameObject Pause;

    // <-- Management --> //
    private GameObject _loadedUI;
    private GameStates _loadedState;

    // <-- Main Stack --> // 
    public void UpdateUI() {
        if (_loadedState != State.state)
        {
            if (_loadedUI == null)
                DestroyUI();

            CreateUI();
        }
    }

    private void CreateUI() {
        switch (State.state) {
            case GameStates.NONE:
                break;
            case GameStates.Stealth:
                break;
            case GameStates.Seeker:
                break;
            case GameStates.Death:
                break;
            case GameStates.Pause:
                break;
        }

        // Create UI
    }

    private void DestroyUI() {
        // TEMP: Change to animations
        Destroy(_loadedUI);
        _loadedUI = null;
    }

    // <-- Getters/Setters --> //
    public GameObject GetUI() {
        return _loadedUI;
    }

}
