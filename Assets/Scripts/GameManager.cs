 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameState _gamestate;

    public void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        _gamestate = GameState.start;
    }

    public void UpdateGameState(GameState gameState)
    {
        _gamestate = gameState;
    }

    public GameState GetGameState => _gamestate;

    public void SwitchPlayer()
    {
        if (_gamestate == GameState.player1)
            _gamestate = GameState.player2;
        else
            _gamestate = GameState.player1;
    }

    // Update is called once per frame
    void Update()
    {
        switch (_gamestate)
        {
            case GameState.start:
                UpdateGameState(GameState.player1);
                break;
            case GameState.player1:
                break;
            case GameState.player2:
                break;
            case GameState.end:
                break;
        }
    }

    public enum GameState
    {
        start,
        player1,
        player2,
        end
    }


}
