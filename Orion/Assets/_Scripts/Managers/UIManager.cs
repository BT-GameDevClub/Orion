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

    // <-- Misc --> //
    public Transform UIHolder;

    // <-- Main Stack --> // 
    public void UpdateUI()
    {
        if (_loadedState != State.state)
        {
            if (_loadedUI != null)
                DestroyUI();

            CreateUI();
        }
    }

    private void CreateUI()
    {
        _loadedState = State.state;
        switch (State.state)
        {
            case GameStates.NONE:
                _loadedUI = None;
                break;
            case GameStates.Stealth:
                _loadedUI = Stealth;
                break;
            case GameStates.Seeker:
                _loadedUI = Seeker;
                break;
            case GameStates.Death:
                _loadedUI = Death;
                break;
            case GameStates.Pause:
                _loadedUI = Pause;
                break;
        }

        // Create UI
        _loadedUI = Instantiate(_loadedUI, UIHolder, false);
  
    }

    private void DestroyUI()
    {
        // TEMP: Change to animations
        Destroy(_loadedUI);
        _loadedUI = null;
    }

    // <-- Getters/Setters --> //
    public GameObject GetUI()
    {
        return _loadedUI;
    }

}