using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public MoleManager moleManager;
    public Slider hp;
    public float dam;

   
    void Update()
    {
        if(moleManager.score == -50){

            hp.value -= dam;
        }
    }
}
