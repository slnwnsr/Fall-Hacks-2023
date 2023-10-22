using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonControl : MonoBehaviour
{
    [SerializeField] private string back = "back";

    public void LoadScene()
    {
        SceneManager.LoadScene(back);
    }
}