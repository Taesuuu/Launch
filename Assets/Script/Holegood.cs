using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Holegood : MonoBehaviour, IPointerDownHandler
{
    public int holeNum2;
    public MoleManager moleManager;
    public MoleManager good;
   

    public void OnPointerDown(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        moleManager.badA[holeNum2].SetActive(false);
        moleManager.good.SetActive(true);
        moleManager.eff[holeNum2].SetActive(false);
        moleManager.score += 200;
        Invoke("goodviw", 0.4f);
        moleManager.goodB[holeNum2].SetActive(true);
        moleManager.hp.value += 2.0f;

    }
    public void goodviw()
    {
        moleManager.good.SetActive(false);
        
    }
}
