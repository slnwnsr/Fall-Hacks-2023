using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFN : MonoBehaviour
{
    // [SerializeField] Objects objects;
    public Objects objects;
    // public int score = 0;
    public int maxScore = 10;

    void OnMouseDown()
    {
        objects.score++;
        Debug.Log("Clicked on object");
        Debug.Log(objects.score);
        Destroy(gameObject);
    }

    public void Update()
    {
        if (objects.score > maxScore || objects.score == maxScore)
        {
            Debug.Log("Reached max score");
            // change the scene
        }
    }
}
