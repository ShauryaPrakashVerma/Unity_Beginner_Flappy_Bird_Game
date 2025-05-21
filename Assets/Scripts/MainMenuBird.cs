using UnityEngine;

public class MainMenuBird : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStength;

    void Start()
    {
        // Automatically bounce once when scene loads
        // rb.linearVelocity = Vector2.up * flapStength;
    }

    void Update()
    {
        // Allow manual bounce via Space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * flapStength;
        }
    }
}
