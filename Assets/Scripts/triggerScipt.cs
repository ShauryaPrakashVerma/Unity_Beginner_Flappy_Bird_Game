// using UnityEngine;

// public class TriggerScript : MonoBehaviour
// {
//     public LogicScript logic;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//     {
//         logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
//         if (logic == null)
//         {
//             Debug.LogError("LogicScript not found! Check if the Logic GameObject is properly tagged.");
//         }
//         else
//         {
//             Debug.Log("LogicScript successfully assigned.");
//         }
//     }
    
//     private void OnTriggerEnter2D(Collider2D collision)
//     {
//         Debug.Log("Something collided with the trigger: " + collision.gameObject.name);
//         if (collision.gameObject.CompareTag("Player"))
//         {
//             Debug.Log("Player tag confirmed! Updating score...");
//             logic.addScore(1);
//         }
//     }
// }

using UnityEngine;

public class BirdTestTrigger : MonoBehaviour
{
    public LogicScript logic;  // Drag your Logic Manager here in Inspector

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something entered the trigger: " + collision.gameObject.name);
        logic.addScore(1);
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     Debug.Log("Triggered by: " + collision.gameObject.name);

    //     if (collision.gameObject.CompareTag("Player"))
    //     {
    //         Debug.Log("Player detected! Adding score!");
    //         logic.addScore(1);
    //     }
    // }
}
