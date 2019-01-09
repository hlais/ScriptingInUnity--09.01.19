using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {

    //instantiate is used to create clones of gameobjects. Similar to duplicate
    //commonly using for cloning a prefab.
    //Prefab is pre-configured object saved in the projects assest

    public Rigidbody rocketPrefab;
    public Transform positionToSpawn;
	
	// Update is called once per frame
	void Update () {

       
        if (Input.GetButtonDown("Fire1"))
        {
          Rigidbody ballz =  Instantiate(rocketPrefab,positionToSpawn.position,positionToSpawn.rotation ) as Rigidbody;
            ballz.AddForce(Vector3.forward * 500000 * Time.deltaTime);
        }
		
	}
}
