using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypes : MonoBehaviour {

    //All variables have a data type,the two primary data Types are: Value and Reference type.
    //Value - int, float, double, bool, char, structs, (common sctructs in unity are vector 3 and querterion)
    //reference - classes, tranform, gameobject,
    // difference? Value type contains some valeues, and reference type has a memory address where value is stored
    //if value type is changed, only that particular variable is effect.
    //if reference is changed, all variable holding that memory address would be effected

	void Start () {
        //the below does not change the game object, and is only changing the value of the vector 3;
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);

        // transform is a class. reference type. this will change behaviour. since we are reference in memory the tranform
        Transform trans = transform;
        trans.position = new Vector3(0, 40, 0);
		
	}
	

	
}
