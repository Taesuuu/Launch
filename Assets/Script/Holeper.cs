using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Holeper : MonoBehaviour, IPointerDownHandler
{
    public int holeNum3;
    public MoleManager moleManager;
    public MoleManager perfect1;

    public void OnPointerDown(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        moleManager.badA[holeNum3].SetActive(false);
        moleManager.perfect1.SetActive(true);
        Invoke("perviw", 0.4f);
        moleManager.perB[holeNum3].SetActive(true);
    }
    public void perviw()
    {
        moleManager.perfect1.SetActive(false);
    }
}