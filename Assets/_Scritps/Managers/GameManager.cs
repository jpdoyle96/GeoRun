using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static event Action<GameState> OnBeforeStateChanged;
    public static event Action<GameState> OnAfterStateChanged;

    [field: SerializeField]  
    internal Player Player { get; private set; }

    public GameState State { get; private set; }

    void Start() => ChangeState(GameState.Start);

    public void ChangeState(GameState newState)
    {
        if (newState != State)
        {
            OnBeforeStateChanged?.Invoke(newState);

            State = newState;
            switch(newState)
            {
                case GameState.Start:
                    HandleStart();
                    break;
                case GameState.Home:
                    HandleHome();
                    break;
                case GameState.Spawn:
                    HandleSpawn();
                    break;
                case GameState.Playing:
                    HandlePlaying();
                    break;
                case GameState.GameOver:
                    HandleGameOver();
                    break;
                case GameState.Pause:
                    HandlePause();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
            }
        }
    }

    private void HandleStart() { }

    private void HandleHome() { }

    private void HandleSpawn() { }

    private void HandlePlaying() { }

    private void HandleGameOver() { }

    private void HandlePause() { }

    // Core Game Loop
    void Update()
    {
    
    }
}

[Serializable]
public enum GameState
{
    Start = 0,
    Home = 1,
    Spawn = 2,
    Playing = 3,
    GameOver = 4,
    Pause = 5
}
