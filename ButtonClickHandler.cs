using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickHandler : MonoBehaviour
{
    private int clickCount = 0;
    public int clicksToSwitchScene = 3; // Set the number of clicks required to switch scenes

    public void OnButtonClick()
    {
        clickCount++;

        if (clickCount >= clicksToSwitchScene)
        {
            // Load the desired scene when the click count reaches the specified limit
            SceneManager.LoadScene("papergame");
        }
    }
}
