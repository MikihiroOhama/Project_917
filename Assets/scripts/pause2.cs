using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause2 : MonoBehaviour
{
    public GameObject reStartButton;
    public GameObject pausePanel;
    public GameObject ExitButton;
    
    public void StopGame()
    {

        Time.timeScale = 0f;
        reStartButton.SetActive(true);
        pausePanel.SetActive(true);
        ExitButton.SetActive(true);
    }
    public void reStartGame()
    {
        reStartButton.SetActive(false);
        pausePanel.SetActive(false);
        ExitButton.SetActive(false);
        Time.timeScale = 1f;
    }
    
    
}
