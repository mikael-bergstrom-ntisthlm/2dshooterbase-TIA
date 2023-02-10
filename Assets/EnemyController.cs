using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
  [SerializeField]
  float speed = 3f;

  void Start()
  {
    float x = Random.Range(-8f, 8f);

    Vector2 position = new Vector2(x, 7);

    transform.position = position;
  }

  void Update()
  {
    Vector2 movement = new Vector2(0, -speed) * Time.deltaTime;

    transform.Translate(movement);

    if (transform.position.y < -7)
    {
      Destroy(this.gameObject);
    }
  }
}
