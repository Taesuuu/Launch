using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Song
{
    public string name;
    public string composer;
    public int bpm;
    public Sprite sprite;


}
public class Play1 : MonoBehaviour
{
    [SerializeField] Song[] songList=null;
    [SerializeField] Text txtSongName=null;
    [SerializeField] Text txtSongComposer=null;
    [SerializeField] Image imgDisk=null;



    //public MoleManager mo;

    public GameObject[] btnlistNo;
    public GameObject[] btnlisthr;

    public int currentSong1=0;

     private void Start()
    {
      SettingSong();
    }

    public void BtnNext()
    {
        if (++currentSong1 > songList.Length-1)
            currentSong1=0;
        SettingSong();
    }
    public void BtnPrior()
    {
        if (--currentSong1 < 0)
            currentSong1 = songList.Length-1;
        SettingSong();
    }

    void SettingSong()
    {
        txtSongName.text=songList[currentSong1].name;
        txtSongComposer.text=songList[currentSong1].composer;
        imgDisk.sprite=songList[currentSong1].sprite;
        for(int i =0; i<5; i++)
        {
            btnlistNo[i].SetActive(false);
            btnlisthr[i].SetActive(false);
        }
        //btnlistNo[0].SetActive(false);
        //btnlistNo[1].SetActive(false);
        //btnlistNo[2].SetActive(false);
        //btnlistNo[3].SetActive(false);
        //btnlistNo[4].SetActive(false);
        btnlisthr[currentSong1].SetActive(true);
        btnlistNo[currentSong1].SetActive(true);

        MoleManager.sonum = currentSong1;
        MoleManager.songs = songList[currentSong1].name;
        MoleManager.namez = songList[currentSong1].composer;

        AudioManager.instance.PlayBGM("BGM" + currentSong1);
    }

    public void Change1()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Change2()
    {
        SceneManager.LoadScene("SampleScene");
        MoleManager.interval = 1f;
    }
    public void Change3()
    {
        SceneManager.LoadScene("SampleScene");
        MoleManager.interval = 0.5f;
    }
}
