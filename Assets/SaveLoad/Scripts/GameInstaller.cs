using Zenject;
using UnityEngine;

public class GameInstaller : MonoInstaller
{
    public UISystem uiSystem;

    public override void InstallBindings()
    {   
        
        Container.Bind<UISystem>().FromInstance(uiSystem).AsSingle();
        Container.Bind<SaveLoadSystem>().AsSingle();
        Container.Bind<GameStateMachine>().AsSingle().NonLazy();

        Container.QueueForInject(new LoadingState(
            Container.Resolve<SaveLoadSystem>(),
            Container.Resolve<UISystem>(),
            Container.Resolve<GameStateMachine>()));

    }

    new void Start(){

        var gameStateMachine = Container.Resolve<GameStateMachine>();
        gameStateMachine.ChangeState(new LoadingState(
            Container.Resolve<SaveLoadSystem>(),
            Container.Resolve<UISystem>(),
            gameStateMachine));

    }

    void Update(){

        if(Input.GetKeyDown(KeyCode.R)){

        var gameStateMachine = Container.Resolve<GameStateMachine>();
        gameStateMachine.ChangeState(new LoadingState(
            Container.Resolve<SaveLoadSystem>(),
            Container.Resolve<UISystem>(),
            gameStateMachine));

        }

    }

}