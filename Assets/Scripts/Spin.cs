using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    //set variable in inspector
    [SerializeField] float speed;

	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.up,  speed * Time.deltaTime);
		
	}
}
