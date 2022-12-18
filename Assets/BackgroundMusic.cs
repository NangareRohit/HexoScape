using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{   
    private static BackgroundMusic backgroudMusic;

    private void Awake() 
    {
        if (backgroudMusic == null)
        {
            backgroudMusic = this;
            DontDestroyOnLoad(backgroudMusic);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
}
