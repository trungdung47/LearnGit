using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    Small,
    Big,
    Special
}
public abstract class CharacterBase : MonoBehaviour
{
    public string idleAnim;
    public string runAnim;
    public string jumpAnim;
    public Animator anim;

    public Rigidbody2D rb;
    public CharacterType characterType;
    public float moveSpeed;
    public float countJump;

    public abstract void Init();

    public void Update()
    {
        Move();
    }
    public virtual void Move()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity += new Vector2(moveSpeed, rb.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
            anim.Play(runAnim);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity -= new Vector2(moveSpeed, rb.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
            anim.Play(runAnim);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            anim.Play(jumpAnim);
        }
    }
    public virtual void Jump()
    {
        rb.AddForce(new Vector2(rb.velocity.x, countJump));
    }
}
