using UnityEngine;
using UnityEngine.UI;

/*this script is used to mute the volume of the game. It uses a toggle to mute and unmute the volume. 
 * The volume is set to 0 when the toggle is on and 1 when the toggle is off. 
 * The script does not save the mute state in player prefs.
 */

public class MuteVolume : MonoBehaviour
{
    [SerializeField] private Toggle MuteVolumeToggle;

    public void MuteVolumeToggleChanged()
    {
        if (MuteVolumeToggle.isOn)
        {
            AudioListener.volume = 0f; // Mute the volume
        }
        else
        {
            AudioListener.volume = 1f; // Unmute the volume
        }
        
    }
}


// this is not wrking ggod enough because of conflict between the volume and the mute toggle . even if the toggle is off the volume stil plays at 
// last saved preference. See how to fix it.
// using UnityEngine;
// using UnityEngine.UI;

// public class MuteVolume : MonoBehaviour
// {
//     [SerializeField] private Toggle MuteVolumeToggle;

//     void Start()
//     {
//         // Load saved mute state
//         if (PlayerPrefs.HasKey("IsMuted"))
//         {
//             bool isMuted = PlayerPrefs.GetInt("IsMuted") == 1;
//             MuteVolumeToggle.isOn = isMuted;
//             AudioListener.volume = isMuted ? 0f : 1f;
//         }
//         else
//         {
//             MuteVolumeToggle.isOn = false;
//             AudioListener.volume = 1f;
//             PlayerPrefs.SetInt("IsMuted", 0);
//         }
//     }

//     public void MuteVolumeToggleChanged()
//     {
//         bool isMuted = MuteVolumeToggle.isOn;

//         AudioListener.volume = isMuted ? 0f : 1f;

//         // Save mute preference
//         PlayerPrefs.SetInt("IsMuted", isMuted ? 1 : 0);
//         PlayerPrefs.Save();
//     }
// }

