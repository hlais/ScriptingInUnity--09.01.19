using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseClick : MonoBehaviour {

    private void OnMouseDown()
    {
       
        Debug.Log("mouse Clicked");
        transform.Translate(Vector3.forward * 50f );
        
    }

}
