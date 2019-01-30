using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    public void MoveCamera(string direction) {
        if (direction == "LEFT") {
            transform.position = new Vector3(transform.position.x - 3.2f, transform.position.y, transform.position.z);
        }else if (direction == "RIGHT") {
            transform.position = new Vector3(transform.position.x + 3.2f, transform.position.y, transform.position.z);
        } else if (direction == "UP") {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1.94f, transform.position.z);
        } else if (direction == "DOWN") {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1.94f, transform.position.z);
        }
    }
}
