using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public bool isPressed;
    public bool needsWire;
    public WireUI wireUI;

    public bool wiresConnected;

    public Animator animator;
    public Door[] doors;

	void Update () {
        if (!needsWire) {
            wiresConnected = true;
        } else {
            wiresConnected = wireUI.allConnected;
        }

        if(isPressed == true) {
            if (wiresConnected) {
                animator.SetBool("ButtonPressed", true);
                foreach (Door door in doors) {
                    door.isOpen = true;
                }
            }
        }
	}

    private void OnTriggerStay2D(Collider2D other)
	{
        if(other.tag == "Player" && Input.GetKey(KeyCode.Space)) {
            if(wiresConnected == true) {
                isPressed = true;
            }
        } 
	}
}
