using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour {

    Renderer renderer;
	void Start () {
        renderer = GetComponent<Renderer>();
        
      
		
	}
    private void Update()
    {
        renderer.material.color = Color.red;
    }

}
