using UnityEngine;

public class WhileLoop : MonoBehaviour {

	int cupsInSink = 4;
	// Use this for initialization
	void Start ()
	{
		while (cupsInSink > 0)
		{
			Debug.Log("I have Washed A cup!");
			cupsInSink--;
		}
		
	}
	
}
