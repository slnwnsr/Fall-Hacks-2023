using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlbutton : MonoBehaviour
{
     [SerializeField] private string back = "SampleScene";
    
    public void LoadScene(){
        SceneManager.LoadScene(back);
    }
}