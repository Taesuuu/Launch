using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ach : MonoBehaviour
{
    public Button[] lebtn;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {

        int lea = PlayerPrefs.GetInt("lea", 2);

        for (int i = 0; i < lebtn.Length; i++)
        {
            if (i + 2 > lea)
                lebtn[i].interactable = false;

           
        }
    }
}
