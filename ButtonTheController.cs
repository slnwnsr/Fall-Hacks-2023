using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller4 : MonoBehaviour
{
    [SerializeField] private string start = "lawyergame";

    public void LoadScene() {
        SceneManager.LoadScene(start);
    }
}
