using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class UsingDeltaTimes : MonoBehaviour {

    float speed = 8f;
    float countDownTime = 60f;
    Light light;

    private void Awake()
    {
        light = GetComponent<Light>();
    }
    // Update is called once per frame
    void Update () {

        countDownTime -= Time.time;

        if (countDownTime < 0f)
        {
            light.enabled = true;


            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            }
        }
		
	}
}
