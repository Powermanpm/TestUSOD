using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UISystem : MonoBehaviour
{
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private Slider progressBar;
    [SerializeField] private TextMeshProUGUI loadingText;
    [SerializeField] private Text gameTimeText;

    public void ShowLoadingScreen(){

        loadingScreen.SetActive(true);

    }

    public void HideLoadingScreen(){

        loadingScreen.SetActive(false);

    }

    public void UpdateLoadingProgress(float progress, string message){

        progressBar.value = progress;
        loadingText.text = message;

    }

    public void UpdateGameTime(float time){
        
        gameTimeText.text = $"Time: {time:F2}";

    }

}
