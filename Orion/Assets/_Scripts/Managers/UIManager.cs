using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI Manager
/// </summary>

public class UIManager : MonoBehaviour
{
    // <-- UIs --> //
    [Header("PlayState UIs")]
    public GameObject InGame;
    public GameObject Paused;

    [Header("GameState UIs")]
    public GameObject Stealth;
    public GameObject Seeker;
    public GameObject Death;

    // <-- Management --> //
    private GameObject _loadedGameStateUI;
    private GameStates _loadedGameState;
    private GameObject _loadedPlayStateUI;
    private PlayStates _loadedPlayState;

    // <-- Misc --> //
    [Header("Canvas")]
    public Transform BaseCanvas;

    // <-- Main Stack --> // 
    public void UpdateUI()
    {
        if (_loadedGameState != State.gameState)
        {
            DestroyGameStateUI();
            CreateGameStateUI();
        }

        if (_loadedPlayState != State.playState) {
            DestroyPlayStateUI();
            CreatePlayStateUI();
        }
    }

    // <-- GameState Functions --> //
    // TODO: Combine with PlayState functions

    private void CreateGameStateUI()
    {
        _loadedGameState = State.gameState;
        switch (State.gameState)
        {
            case GameStates.NONE:
                _loadedGameStateUI = null;
                return;
            case GameStates.Stealth:
                _loadedGameStateUI = Stealth;
                break;
            case GameStates.Seeker:
                _loadedGameStateUI = Seeker;
                break;
            case GameStates.Death:
                _loadedGameStateUI = Death;
                break;
        }

        // Create UI
        _loadedGameStateUI = Instantiate(_loadedGameStateUI, BaseCanvas, false);
  
    }

    private void DestroyGameStateUI()
    {
        // TEMP: Change to animations
        if (_loadedGameStateUI == null) return;
        Destroy(_loadedGameStateUI);
        _loadedGameStateUI = null;
    }

        // <-- Getters/Setters --> //
        public GameObject GetGameStateUI()
        {
            return _loadedGameStateUI;
        }

    // <-- PlayState Functions --> //
    private void CreatePlayStateUI()
    {
        _loadedPlayState = State.playState;
        switch (State.playState)
        {
            case PlayStates.NONE:
                _loadedPlayStateUI = null;
                return;
            case PlayStates.InGame:
                _loadedPlayStateUI = InGame;
                break;
            case PlayStates.Paused:
                _loadedPlayStateUI = Paused;
                break;
        }

        Debug.Log(_loadedPlayStateUI.name);

        // Create UI
        _loadedPlayStateUI = Instantiate(_loadedPlayStateUI, BaseCanvas, false);
  
    }

    private void DestroyPlayStateUI()
    {
        // TEMP: Change to animations
        if (_loadedPlayStateUI == null) return;
        Destroy(_loadedPlayStateUI);
        _loadedPlayStateUI = null;
    }

        // <-- Getters/Setters --> //
        public GameObject GetPlayStateUI()
        {
            return _loadedPlayStateUI;
        }

}