using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class ObjectEnabler : MonoBehaviour {
    [SerializeField] GameObject video1;
    [SerializeField] GameObject video2;
    GameObject imposter;
   


    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {

        Invoke("MethodMan", 5f);

        imposter = GameObject.Find("Imposter");
        if (imposter == null)
        {
            video1.SetActive(false);
            video2.SetActive(true);
        }
        else
        {
            video1.SetActive(true);
            video2.SetActive(false);
        }
    }
    private void MethodMan()
    {
        print("Hello World");
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Imposter")
    //    {

    //        video1.SetActive(false);
    //        video2.SetActive(true);
    //        If the GameObject's name matches the one you suggest, output this message in the console
    //        Debug.Log("Do something here");
    //    }
    //    else
    //    {
    //        video1.SetActive(true);
    //        video2.SetActive(false);
    //    }

    //}
}
