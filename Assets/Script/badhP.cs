using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badhP : MonoBehaviour
{
    public HPBar bar;
    public void badHp()
    {
        bar.hp.value -= 10f;
      
    }
   
}
