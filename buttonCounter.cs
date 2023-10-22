using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickController : MonoBehaviour
{
    public Button ClickButton;
    public Button Divorce1;

    private int clickCount = 0;

    void Start()
    {
        ClickButton.onClick.AddListener(OnButtonAClick);
        Divorce1.interactable = false; // Disable Button B initially
    }

    void OnButtonAClick()
    {
        clickCount++;
        // Update UI or do something with the click count if needed
        Debug.Log("Click Count: " + clickCount);

        if (clickCount >= 20)
        {
            // Enable Button B when click count is 20 or more
            Divorce1.interactable = true;
        }
    }
}
