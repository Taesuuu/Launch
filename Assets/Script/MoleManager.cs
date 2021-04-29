using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] badA;
    public GameObject[] badB;
    public GameObject[] perB;
    public GameObject[] goodB;
    public GameObject[] hole1;
    public GameObject[] hole2;
    public GameObject[] hole3;

    public GameObject perfect1;
    public GameObject good;
    public GameObject bad;
    public int m;

    public float interval;

    void Start()
    {
      interval = 1;
      StartCoroutine("Moleup");
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
      }
    }
  }
    private void Update()
    {

    }
}

