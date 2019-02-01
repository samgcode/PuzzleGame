using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private SpriteRenderer renderer_;
    private BoxCollider2D collider_;
    private SceneManegment sceneManeger;

    public bool isOpen;
    public Sprite openSprite;
    public Sprite closedSprite;

    public bool isEndDoor;


	private void Start()
	{
        renderer_ = GetComponent<SpriteRenderer>();
        collider_ = GetComponent<BoxCollider2D>();
        sceneManeger = FindObjectOfType<SceneManegment>();
	}

	private void Update()
	{
        if (!isEndDoor) {
            if (isOpen) {
                renderer_.sprite = openSprite;
                collider_.isTrigger = true;
            } else {
                renderer_.sprite = closedSprite;
                collider_.isTrigger = false;
            }
        }
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
        if(isEndDoor && other.tag == "Player") {
            sceneManeger.NextLevel();
        }
	}
}
