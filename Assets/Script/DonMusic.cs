using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonMusic : MonoBehaviour
{

    private void Start()
    {
        // DontDestroyOnLoad(gameObject);
        song();
       
    }

    // Update is called once per frame
   void song()
    {
        if (Play1.currentSong1 == 0)
        {
            AudioManager.instance.PlayBGM("BGM" + 0);
        }
        if (Play1.currentSong1 == 1)
        {
            AudioManager.instance.PlayBGM("BGM" + 1);
        }
        if (Play1.currentSong1 == 2)
        {
            AudioManager.instance.PlayBGM("BGM" + 2);
        }
        if (Play1.currentSong1 == 3)
        {
            AudioManager.instance.PlayBGM("BGM" + 3);
        }
        if (Play1.currentSong1 == 4)
        {
            AudioManager.instance.PlayBGM("BGM" + 4);
        }
    }
}
