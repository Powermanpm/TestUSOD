using System.Threading.Tasks;
using Zenject;

public interface IGameState{

    Task Enter();
    void Exit();
    
}