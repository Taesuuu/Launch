using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Slider hp;
    public MoleManager moleManager;
    
   

   
    void Update()
    {
        
        hp.value -= 1.0f * Time.deltaTime;

    
        }
    }
    

