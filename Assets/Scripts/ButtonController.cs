using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

public void startButton()
    {
        SceneManager.LoadScene(1);
    }

    public void mainmenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void quitButton()
    {
        Application.Quit();
    }

    public void menuButton()
    {

    }

    public void creditsButton()
    {

    }
}
