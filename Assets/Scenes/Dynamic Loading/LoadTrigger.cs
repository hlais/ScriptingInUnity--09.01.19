using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTrigger : MonoBehaviour {

    public string loadName;
    public string unloadName;

    private void OnTriggerEnter(Collider other)
    {
        if (loadName != "")
        {
            SceneManagerDynamic.Instance.Load(loadName);
        }

        if (unloadName != "")
        {
            Debug.Log("play");

           StartCoroutine(UnloadScene());
        }
    }
    IEnumerator UnloadScene()
    {
        yield return new WaitForSeconds(0.10f);
        SceneManagerDynamic.Instance.Unload(unloadName);
    }
}
