using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour {

    int enemies = 3;
	
	void Start ()
    {
        for (int i = 0; i < enemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
		
	}
    //i stands for itterator
    //for loop is usual when the number of itteration is known
    // in general in coding counting begins at 0 
	
}
