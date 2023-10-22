using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    [SerializeField] private string start = "papergame";

    public void LoadScene() {
        SceneManager.LoadScene(start);
    }
}
