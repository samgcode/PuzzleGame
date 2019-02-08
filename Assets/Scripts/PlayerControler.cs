﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour {

    public CameraScript cam;
    public Button button;
    public Animator animator;
    public float speed = 10f;
    public Rigidbody2D rb;
    public GameObject[] tutorialText;
    public int room;
    public SceneManegment maneger;
    public CircleCollider2D col;

    public bool devMode = false;

    public int level;

	private void Start()
	{
        speed = 0.8f;
        maneger = FindObjectOfType<SceneManegment>();
        cam = FindObjectOfType<CameraScript>();
	}

	void Update () {
        level = maneger.level_;

        if(Input.GetKey(KeyCode.LeftShift)) {
            speed = 1.2f;
        } else if(devMode == true) {
            speed = 2;
            col.isTrigger = true;
        } else {
            col.isTrigger = false;
            speed = 0.8f;
        }

        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;

        Vector2 newPos = new Vector2(rb.position.x + x, rb.position.y + y);
        //newPos.x = Mathf.Clamp(newPos.x, -mapWidth, mapWidth);
        //newPos.y = Mathf.Clamp(newPos.y, -mapHeight, mapHeight);
        rb.position = newPos;

        if(Input.anyKey) {
            animator.SetBool("isWalking", true);
        } else {
            animator.SetBool("isWalking", false);
        }


        if(Input.GetKey(KeyCode.Escape)) {
            maneger.TitleScreen();
        }

        if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow)) {
            transform.eulerAngles = new Vector3(0f, 0f, 45f);
        } else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)) {
            transform.eulerAngles = new Vector3(0f, 0f, -45f);
        } else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow)) {
            transform.eulerAngles = new Vector3(0f, 0f, 135f);
        } else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow)) {
            transform.eulerAngles = new Vector3(0f, 0f, -135f);
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.eulerAngles = new Vector3(0f, 0f, 180f);
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.eulerAngles = new Vector3(0f, 0f, 90f);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.eulerAngles = new Vector3(0f, 0f, -90f);
        }

        //if(Input.GetKey(KeyCode.W)) {
        //    transform.position += transform.up * (speed / 10);
        //    animator.SetBool("isWalking", true);
        //} else {
        //    animator.SetBool("isWalking", false);
        //}

        //var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        //var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        string tag_ = other.tag;
        string name_ = other.name;

        //if(tag_ != "Button") {
        //    foreach(var text in tutorialText) {
        //        text.SetActive(false);
        //    }
        //}

        int roomNum;

        if (int.TryParse(name_, out roomNum)) {
            room = roomNum;
            Debug.Log(roomNum);
        }

        switch(tag_) {
            case "RIGHT": 
                cam.MoveCamera("RIGHT");
                transform.position = new Vector3(transform.position.x + 0.8f, transform.position.y, transform.position.z);
                break;
            case "LEFT":
                cam.MoveCamera("LEFT");
                transform.position = new Vector3(transform.position.x - 0.8f, transform.position.y, transform.position.z);
                break;
            case "UP":
                cam.MoveCamera("UP");
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.8f, transform.position.z);
                break;
            case "DOWN":
                cam.MoveCamera("DOWN");
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.8f, transform.position.z);
                break;
        }
	}
}
