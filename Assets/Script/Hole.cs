using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hole : MonoBehaviour, IPointerDownHandler
{
    public int holeNum1;
    public MoleManager moleManager;
    public static MoleManager bad;
    

    public void OnPointerDown(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        moleManager.badA[holeNum1].SetActive(false);
        moleManager.bad.SetActive(true);
        moleManager.eff[holeNum1].SetActive(false);
        moleManager.score += 100;

        Invoke("badviw", 0.4f);
        moleManager.badB[holeNum1].SetActive(true);
        moleManager.hp.value -= 3.0f;

    }
    public void badviw()
    {
        moleManager.bad.SetActive(false);
        
    }
}
