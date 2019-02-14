using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour {

    public bool isConnected;
    public GameObject obj;

	public void show() {
        obj.SetActive(true);
    }
}
