using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class EnergyBar : MonoBehaviour {

    //select the colors in the inspector 
    public Color green;
    public Color orange;
    public Color red;

    //this is variable to enable colour changing
    //change this value between 0 - 1.00 to change colours
    public float energyBarStatus;


	
	// Update is called once per frame
	void Update () {

        //we are waiting for value;
        upDateColor();
		
	}

    void upDateColor()
    {
        
        if (energyBarStatus >= 0.5)
        {
            GetComponent<Renderer>().material.color = green;
        }
        else if (energyBarStatus > 0.20 && energyBarStatus < 0.50)
        {
            GetComponent<Renderer>().material.color = orange;

        }
        else
        {
            GetComponent<Renderer>().material.color = red;
        }
    }
}
