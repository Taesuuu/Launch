using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public int moleNum;
    public MoleManager moleManager;
    public HPBar HPBar;

    void DisableObj(){
      
      gameObject.SetActive(false);
    }
    void HoleOn1(){
      moleManager.hole1[moleNum].SetActive(true);
    }
    void HoleOff1(){
      moleManager.hole1[moleNum].SetActive(false);
    }
    void HoleOn2()
    {
        moleManager.hole2[moleNum].SetActive(true);
    }
    void HoleOff2()
    {
        moleManager.hole2[moleNum].SetActive(false);
    }
    void HoleOn3()
    {
        moleManager.hole3[moleNum].SetActive(true);
    }
    void HoleOff3()
    {
        moleManager.hole3[moleNum].SetActive(false);
        moleManager.score -= 50;
        HPBar.hp.value -= 10f;
    }
}
