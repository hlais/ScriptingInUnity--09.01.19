using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorMoveScript : MonoBehaviour {

    float inputAxis;
    Animator animator;

    public void Start()
    {
      animator =   GetComponent<Animator>();
    }

  

    public void Update()
    {
        animator.SetFloat("Forward", Input.GetAxis("Vertical"));
    }


    private void OnAnimatorMove()
    {
        

        if (animator)
        {
            Vector3 newPosition = transform.position;
            newPosition.z += animator.GetFloat("Forward") * Time.deltaTime;
            transform.position = newPosition;
        }


    }
}
