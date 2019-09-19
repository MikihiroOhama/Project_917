using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
   
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void OnRetry()
    {
        SceneManager.LoadScene("Pause");
    }
}
