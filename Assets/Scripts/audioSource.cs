using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keeps this GameObject when changing scenes
        }
        else
        {
            Destroy(gameObject); // Prevent duplicate MusicManagers
        }
    }
}
