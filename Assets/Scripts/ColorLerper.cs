using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorLerper : MonoBehaviour {

    public float speed = -1;
    public Color startColor;
    public Color endColor;
    float startTime;

    public bool repeatable = false;

	void Start () {

        startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!repeatable)
        {
            float t = (Time.time - startTime) * speed;
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        }
        else
        {
            float t = (Mathf.Sin(Time.time - startTime) * speed);
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        }
		
	}
}
