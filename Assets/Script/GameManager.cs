using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject StopSet;

    public void StopGame()
    {
        StopSet.SetActive(true);
        Time.timeScale = 0;
    }

    public void ReStart()
    {
        StopSet.SetActive(false);
        Time.timeScale = 1;

    }
    public void Backmeu()
    {
        SceneManager.LoadScene("Music");
        Time.timeScale = 1;
    }

    
}
