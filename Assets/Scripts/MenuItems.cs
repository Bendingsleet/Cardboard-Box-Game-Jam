using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuItems : MonoBehaviour
{
    public string firstSceneTitle;
    public void launchGame()
    {
        SceneManager.LoadScene(firstSceneTitle);
    }
    public void quit()
    {
        Application.Quit();
    }
}
