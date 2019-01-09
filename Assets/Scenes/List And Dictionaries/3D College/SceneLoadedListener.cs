using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoadedListener : MonoBehaviour {

    string logMessage;
    private void Start()
    {
        SceneManager.sceneLoaded += HandleSceneLoaded;
        
    }
    private void HandleSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        logMessage = string.Format("Scene {0} loaded in mode {1}", arg0, arg1);
        Debug.Log(logMessage);
    }
    private void Update()
    {
       Debug.Log(logMessage);
    }
    private void test()
    {
        Debug.Log("HELLOO");
    }

    //private void HandleSceneLoaded(Scene arg0, LoadSceneMode arg1)
    //{
    //    string logMessage = string.Format("Scene {0} loaded in mode {1}", arg0, arg1);
    //    Debug.Log(logMessage);
    //}
}
