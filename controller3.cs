using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller3 : MonoBehaviour
{
    [SerializeField] private string start = "Signing";

    public void LoadScene() {
        SceneManager.LoadScene(start);
    }
}
