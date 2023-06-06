using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    public void PressSelection(int _sceneid)
    { 
            SceneManager.LoadScene(_sceneid);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }


    public void Quit()
    {
        Application.Quit();
    }
}
