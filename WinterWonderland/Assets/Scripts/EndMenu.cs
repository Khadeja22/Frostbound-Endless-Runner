using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{


    public void Restart()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void Quit()
    {
        Application.Quit();
    }

}