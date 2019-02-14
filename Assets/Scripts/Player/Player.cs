using UnityEngine;

public class Player : MonoBehaviour {

    public CameraScript cam;
    public SceneManegment maneger;

    public Animator animator;

    public Rigidbody2D rb;
    public CircleCollider2D col;

    public GameObject[] tutorialText;

    public float speed = 10f;

    public int room;
    public int level;

    public bool inWireMenu = false;
    public bool canMove = true;
    public bool devMode = false;
}
