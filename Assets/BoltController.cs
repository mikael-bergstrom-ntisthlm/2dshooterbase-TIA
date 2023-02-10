using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltController : MonoBehaviour
{
  [SerializeField]
  float speed = 3f;

  void Update()
  {
    Vector2 movement = new Vector2(0, speed) * Time.deltaTime;

    transform.Translate(movement);

    if (transform.position.y > 7)
    {
      Destroy(this.gameObject);
    }
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag == "enemy")
    {
      Destroy(this.gameObject);
    }
  }
}
