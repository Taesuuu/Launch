using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class levelmanager : MonoBehaviour
{

    //public GameObject[] expPool;
    public int level = 1;
    public int maxlevel;
    public int[] maxexp;
    public static int curexp;
    public Image lev;
    public TextMeshProUGUI levelText;



    // Start is called before the first frame update
    void Start()
    {
        maxlevel = PlayerPrefs.GetInt("levels", level);
    }

    // Update is called once per frame
    void Update()
    {
        
        lev.fillAmount = curexp / (float)maxexp[maxlevel - 1];

        if (curexp >= maxexp[maxlevel - 1])
        {
            maxlevel++;
            curexp = 0;
        }
        Debug.Log(curexp);
    }

    private void LateUpdate()
    {
        //levelText.text = PlayerPrefs.GetInt("levels").ToString();
        levelText.text = maxlevel.ToString();
    }

    
}
