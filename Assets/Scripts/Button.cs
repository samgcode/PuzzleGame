using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public bool isPressed;
    public Animator animator;
    public Door[] doors;

	void Update () {
        
        if(isPressed == true) {
            animator.SetBool("ButtonPressed", true);
            foreach(Door door in doors) {
                door.isOpen = true;
            }
        }
	}
    private void OnTriggerStay2D(Collider2D other)
	{
        if(other.tag == "Player" && Input.GetKey(KeyCode.Space)) {
            isPressed = true;
        } 
	}
}
