using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour {

    //only accessed via MyAge method
    private int experience;

    public int Experience
    {
        get
        {
          
            return experience;
        }
        set
        {
            experience = value;
        }
    }


    public int Level
    {
        get
        {
            return experience / 1000;
        }
        
        set { experience = value * 100; }
    }
		

}
