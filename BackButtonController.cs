using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonController : MonoBehaviour
{
    [SerializeField] private string back = "MainMenu";
    
    public void LoadScene(){
        SceneManager.LoadScene(back);
    }
}
