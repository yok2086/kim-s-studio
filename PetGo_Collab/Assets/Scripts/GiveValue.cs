using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveValue : MonoBehaviour 
{
    public float hungryBar;
    public float cleanBar; 
    public float sleepBar; 

    public void Start() 
    {
        hungryBar = StaticData.hungryBar;
        cleanBar = StaticData.cleanBar;
        sleepBar = StaticData.sleepBar;
       
    }
 
}