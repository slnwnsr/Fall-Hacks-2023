using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickController5 : MonoBehaviour
{
    public Button ClickButton;
    public Button Divorce2;

    private int clickCount = 0;

    void Start()
    {
        ClickButton.onClick.AddListener(OnButtonDClick);
        Divorce2.interactable = false; // Disable Button B initially
    }

    void OnButtonDClick()
    {
        clickCount++;
        // Update UI or do something with the click count if needed
        Debug.Log("Click Count: " + clickCount);

        if (clickCount >= 25)
        {
            // Enable Button B when click count is 20 or more
            Divorce2.interactable = true;
        }
    }
}
