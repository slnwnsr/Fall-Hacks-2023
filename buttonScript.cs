using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        // ...
    }

    public void ReactivateButton()
    {
        // Reactivate the button GameObject
        gameObject.SetActive(true);
    }

    void OnClick()
    {
        // Play your animation using animator.Play or trigger a parameter
    }
}
