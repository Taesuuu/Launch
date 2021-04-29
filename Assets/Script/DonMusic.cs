using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonMusic : MonoBehaviour
{

    private void Start()
    {
       DontDestroyOnLoad(gameObject);    
    }

}
