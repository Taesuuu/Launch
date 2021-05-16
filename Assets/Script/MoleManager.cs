using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MoleManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject menuset;
    public GameObject[] badA;
    public GameObject[] eff;
    public GameObject[] badB;
    public GameObject[] perB;
    public GameObject[] goodB;
    public GameObject[] hole1;
    public GameObject[] hole2;
    public GameObject[] hole3;

    public GameObject perfect1;
    public GameObject good;
    public GameObject bad;
    public GameObject count2;
    public GameObject count1;

    public GameObject[] blue;
    public GameObject[] yellow;
    public GameObject[] red;

    public GameObject scores;
    public GameObject endgame;

    public TextMeshProUGUI so;
    public TextMeshProUGUI names;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI isscore;
    public TextMeshProUGUI timetext;


    public TextMeshProUGUI endso;
    public TextMeshProUGUI endnames;
    public TextMeshProUGUI endscore;
    public AudioSource ad;

    public Slider hp;

    
    //public int[] maxexp;

    public static string songs;
    public static string namez;

    public bool gogo = true;
    public int m;
    public float times;
    public float mine;
    public string playgame;
    public int maxtime;
    public int score;

    public static int sonum;

    public static float interval = 1;

    void Start()
    {
        ad = GetComponent<AudioSource>();
        gogo = true;
        score = 0;
        endgame.SetActive(false);
        gametime();
        Debug.Log(sonum);
        Debug.Log(interval);
        count2.SetActive(false);
        count1.SetActive(false);
        Time.timeScale = 1;
        StartCoroutine("Moleup");
        AudioManager.instance.PlayBGM("BGM" + sonum);
        scoreText.text = "00";

        so.text = songs;
        names.text = namez;

        

    }

  IEnumerator Moleup()
  {
    while(gogo)
    {
      yield return new WaitForSeconds(interval);
      m = Random.Range(0, badA.Length);
      if(!badA[m].activeSelf && ! badB[m].activeSelf)
      {
        badA[m].SetActive(true);
        eff[m].SetActive(true);
       }
    }
  }


    private void Update()
    {
        hp.value -= 1.0f * Time.deltaTime;
        times += Time.deltaTime;
        scoreText.text = score.ToString();
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

        if(times > maxtime)
        {
          
            ad.Stop();
            endgame.SetActive(true);
            endso.text = songs;
            endnames.text = namez;
            endscore.text = "Score : " + score.ToString();
            ad.Stop();

           // levelmanager.curexp += 5;

            //if (levelmanager.curexp >= maxexp[levelmanager.level - 1])
            //{
            //    levelmanager.level++;
            //    levelmanager.curexp = 0;
            //}

            for (int z = 0; z < badA.Length; z++)
            {
                badA[z].SetActive(false);
                eff[z].SetActive(false);
            }
            Time.timeScale = 0;
        }
        if (hp.value == 0)
        {

            ad.Stop();
            endgame.SetActive(true);
            endso.text = songs;
            endnames.text = namez;
            endscore.text = "Score : " + score.ToString();

            //levelmanager.curexp += 5;

            ad.Stop();
            for (int z = 0; z < badA.Length; z++)
            {
                badA[z].SetActive(false);
                eff[z].SetActive(false);
            }
            Time.timeScale = 0;
        }
    }


    public void Change()
    {
        SceneManager.LoadScene("Music");
        levelmanager.curexp += 7;
        //levelmanager.maxlevel = PlayerPrefs.GetInt("maxlevel", levelmanager.level);
    }

    public void menuUp()
    {
        scores.SetActive(false);
        menuset.SetActive(true);
        isscore.text = "Score : " + score.ToString();

        int min = (int)times / 60;
        int sec = (int)times % 60;

        timetext.text = min.ToString("00")+ ":" + sec.ToString("00") + " / " + playgame;

        for (int z =0; z < badA.Length; z++)
        {
            badA[z].SetActive(false);
            eff[z].SetActive(false);
        }
        gogo = false;
        ad.Pause();
        Time.timeScale = 0;

    }
    public void menudown()
    {
        menuset.SetActive(false);
        scores.SetActive(true);
        StartCoroutine("Startsss");
        times -= 2.0f;
        for (int z = 0; z < badA.Length; z++)
        {
            badA[z].SetActive(false);
            eff[z].SetActive(false);
        }
        //ad.Play();
    }
    public void threes()
    {
        Time.timeScale = 1;
        ad.Play();
    }
    IEnumerator Startsss()
    {
        Debug.Log("2초 후에");
        Time.timeScale = 1;
        
        count2.SetActive(true);
        Invoke("counup", 1.0f);
        Invoke("coundown", 1.7f);
        yield return new WaitForSeconds(2.0f);
        
        Debug.Log("2초 지남");
       
        gogo = true;
        StartCoroutine("Moleup");
        ad.Play();
    }

    public void gametime()
    {
        switch(sonum){
            case 0: playgame = "02:56";
                maxtime = 10;              
                break;
            case 1:
                playgame = "02:34";
                maxtime = 154;
                break;
            case 2:
                playgame = "03:02";
                maxtime = 182;
                break;
            case 3:
                playgame = "03:01";
                maxtime = 181;
                break;
            case 4:
                playgame = "02:55";
                maxtime = 175;
                break;
        }
    }

    public void counup()
    {
        count2.SetActive(false);
        count1.SetActive(true);
    }
    public void coundown()
    {
        count1.SetActive(false);
    }
}
