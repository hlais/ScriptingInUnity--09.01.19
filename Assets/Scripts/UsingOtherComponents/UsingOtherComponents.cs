using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour {

    // insert other cube
    public GameObject otherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;

    private BoxCollider boxCol;

    private void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = GetComponent<YetAnotherScript>();

        //get box collider
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }

    private void Start()
    {
        //we can control/ change other cube// this would allow us to control the boxColider
        boxCol.size = new Vector3(1000, 9, 9);
        Debug.Log("The Player Score is: " + anotherScript.playerScore);
        Debug.Log("The Player Death is: " + yetAnotherScript.playerDeaths);
    }

}

