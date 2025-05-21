using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore=0;
    public Text scoreText;
    public GameObject gameOverScreen;
    
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        Debug.Log("Score is now: " + playerScore);
        scoreText.text = playerScore.ToString();
    }


    public void restartGame()
    {
        Time.timeScale = 1; // 🔁 Resume time before reloading
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    // public void restartGame()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    // }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0; // Pause the game
        Debug.Log("Game Over! Final Score: " + playerScore);
    }
        
}
