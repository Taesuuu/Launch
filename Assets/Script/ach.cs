using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ach : MonoBehaviour
{
    public Button[] lebtn;

    public Button[] btnN;
    public Button[] btnH;


    public Play1 play;
   
    // Start is called before the first frame update
    void Start()
    {

       // int lea = PlayerPrefs.GetInt("lea", 2);

        //for (int i = 0; i < lebtn.Length; i++)
        //{
        //    if (i + 2 > lea)
        //    {
        //        lebtn[i].interactable = false;
        //    }

        //}
        
        
        for (int x = 0; x < btnH.Length; x++)
        {
            btnH[x].interactable = false;
        }

        btnN[0].interactable = true;
        btnH[0].interactable = true;
    }
}
