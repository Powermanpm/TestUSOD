using System.Threading.Tasks;
using UnityEngine;
public class GamePlayState : IGameState
{
    private readonly UISystem _uiSystem;
    private readonly GameStateMachine _gameStateMachine; //for ChangeState()
    private float _gameTime;

    public GamePlayState(UISystem uiSystem, GameStateMachine gameStateMachine){

        _uiSystem = uiSystem;
        _gameStateMachine = gameStateMachine;

    }

    public async Task Enter(){

        _gameTime = 0;
        while (true){   

            _gameTime += Time.deltaTime;
            _uiSystem.UpdateGameTime(_gameTime);
            await Task.Yield(); 

        }

    }

    public void Exit(){

    }
}