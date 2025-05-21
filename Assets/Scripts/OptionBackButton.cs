using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionBackButton : MonoBehaviour
{
    public void LoadScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("try main menu");
    }
}
