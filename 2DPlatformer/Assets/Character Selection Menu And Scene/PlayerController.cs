using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool enabled;
    public float playerSpeed;
    Animator animator;
    SpriteRenderer sprite;
    void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (enabled)
        {
            float input = Input.GetAxis("Horizontal");
            if (input > 0.5f)
            {
                animator.SetBool("Walk", true);
                sprite.flipX = false;

            }
            else if (input < -0.5f)
            {
                animator.SetBool("Walk", true);
                sprite.flipX = true;

            }
            else
            {
                animator.SetBool("Walk", false);
            }
            transform.position += input * Vector3.right * playerSpeed * Time.deltaTime;
        }

    }
}
