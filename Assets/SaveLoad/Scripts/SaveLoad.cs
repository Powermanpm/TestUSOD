using System.Threading.Tasks;
public class SaveLoadSystem
{
    public async Task<GameData> LoadGameData(){

        await Task.Delay(1000);
        return new GameData();
        
    }

}
public class GameData{
    
}