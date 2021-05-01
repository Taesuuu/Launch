using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class play : MonoBehaviour
{
    public GameObject menuset;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuset.activeSelf)
            {
                menudown();
            }
            else
            {
                menuUp();
            }
           
        }
    }
    public void Change()
    {
        SceneManager.LoadScene("Music");
    }

    public void menuUp()
    {
        menuset.SetActive(true);
    }
    public void menudown()
    {
        menuset.SetActive(false);
    }
}
