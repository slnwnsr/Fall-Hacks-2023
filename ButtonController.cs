using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoncontroll : MonoBehaviour
{
    [SerializeField] private string start = "SampleScene";
    
    public void LoadScene(){
        SceneManager.LoadScene(start);
    }

    public void QuitGame(){
        Application.Quit();
    }
}