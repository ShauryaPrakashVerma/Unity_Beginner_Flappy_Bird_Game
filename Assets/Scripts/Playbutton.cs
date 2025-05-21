using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour
{
    public void LoadSampleScene()
    {
        SceneManager.LoadScene("options");
    }
}

