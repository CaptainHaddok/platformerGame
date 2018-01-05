using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour {
    public void quit()
    {
        Application.Quit();
    }
    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
