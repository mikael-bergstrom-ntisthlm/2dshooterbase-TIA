using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
  [SerializeField]
  Transform groundChecker;

  [SerializeField]
  float jumpForce = 100;

  [SerializeField]
  float speed = 1f;

  [SerializeField]
  LayerMask groundLayer;

  Rigidbody2D rb;

  bool hasReleasedJump = true;
  bool isGrounded = false;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    float xMove = Input.GetAxisRaw("Horizontal");
    Vector2 movement = new Vector2(xMove, 0) * speed * Time.deltaTime;
    transform.Translate(movement);

    isGrounded = Physics2D.OverlapCircle(groundChecker.position, 0.1f, groundLayer);

    if (Input.GetAxisRaw("Jump") > 0 && hasReleasedJump == true && isGrounded == true)
    {
      rb.AddForce(Vector2.up * jumpForce);
      hasReleasedJump = false;
    }
    else if (Input.GetAxisRaw("Jump") == 0)
    {
      hasReleasedJump = true;
    }
  }
}
