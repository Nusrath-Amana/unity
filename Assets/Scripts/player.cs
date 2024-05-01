using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;

    public Rigidbody2D mybody;

    private SpriteRenderer sr;

    private Animator anim;

    private string wWALK_ANIMATION = "walk";

    private void Awake()
    {
        mybody.AddForce(new Vector2(2, 2));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
