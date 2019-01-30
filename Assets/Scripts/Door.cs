using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private SpriteRenderer renderer_;
    private BoxCollider2D collider_;
    public bool isOpen;
    public Sprite openSprite;
    public Sprite closedSprite;

	private void Start()
	{
        renderer_ = GetComponent<SpriteRenderer>();
        collider_ = GetComponent<BoxCollider2D>();
	}

	private void Update()
	{
        if(isOpen) {
            renderer_.sprite = openSprite;
            collider_.isTrigger = true;
        } else {
            renderer_.sprite = closedSprite;
            collider_.isTrigger = false;
        }
	}
}
