using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleManager : MonoBehaviour
{
    // Start is called before the first frame update

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

    public GameObject[] blue;
    public GameObject[] yellow;
    public GameObject[] red;

    public int m;

    public static int sonum;

    public static float interval = 1;

    void Start()
    {

      Debug.Log(sonum);
      Debug.Log(interval);

      StartCoroutine("Moleup");
      AudioManager.instance.PlayBGM("BGM" + sonum);
     
    }

  IEnumerator Moleup()
  {
    while(true)
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

    }
}
