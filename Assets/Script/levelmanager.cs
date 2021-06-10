using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class levelmanager : MonoBehaviour
{

    //public GameObject[] expPool;
    public static int level = 1;
    public int maxlevel;
    public int[] maxexp;
    public static int curexp;
    public Image lev;
    public TextMeshProUGUI levelText;



    // Start is called before the first frame update
    void Start()
    {

        level = 1;
        level = PlayerPrefs.GetInt("levelss");

        curexp = PlayerPrefs.GetInt("exps");
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("levelss", level);
        PlayerPrefs.SetInt("exps", curexp);

        maxlevel = PlayerPrefs.GetInt("levelss");
        lev.fillAmount = curexp / (float)maxexp[maxlevel];

        if (curexp >= maxexp[maxlevel])
        {
            level++;
            curexp = 0;
        }
        Debug.Log(maxlevel);
    }

    private void LateUpdate()
    {
        //levelText.text = PlayerPrefs.GetInt("levels").ToString();
        levelText.text = maxlevel.ToString();
    }

    public void getExp(int i)
    {
        curexp += i;
    }
}
