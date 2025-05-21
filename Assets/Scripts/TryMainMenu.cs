using UnityEngine;
using UnityEngine.SceneManagement;

public class TryMainMenu : MonoBehaviour
{
    
   public void LoadScene()
   {
      Time.timeScale = 1;
      SceneManager.LoadScene("try main menu");
    
   }
//    birdAnimator.Play("BounceAnimation", -1, 0f);

}


