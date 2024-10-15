using System.Threading.Tasks;

public class LoadingState : IGameState
{
    private readonly SaveLoadSystem _saveLoadSystem;
    private readonly UISystem _uiSystem;
    private readonly GameStateMachine _gameStateMachine;

    public LoadingState(SaveLoadSystem saveLoadSystem, UISystem uiSystem, GameStateMachine gameStateMachine){

        _saveLoadSystem = saveLoadSystem;
        _uiSystem = uiSystem;
        _gameStateMachine = gameStateMachine;

    }

    public async Task Enter(){

        _uiSystem.ShowLoadingScreen();
        _uiSystem.UpdateLoadingProgress(0, "Loading game data...");
        
        var gameData = await _saveLoadSystem.LoadGameData();
        _uiSystem.UpdateLoadingProgress(1, "Loading complete!");

        await Task.Delay(1000); 
        _uiSystem.HideLoadingScreen();
        
        _gameStateMachine.ChangeState(new GamePlayState(_uiSystem, _gameStateMachine));

    }

    public void Exit(){ 

    }

}
