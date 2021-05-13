using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Slider hp;

    public void badhp()
    {
        hp.value -= 5.0f;
    }
    public void goodhp()
    {
        hp.value = 0f;
    }
    public void perhp()
    {
        hp.value += 5.0f;
    }

    void Update()
    {

        hp.value -= 1.0f * Time.deltaTime;
    }
    }

