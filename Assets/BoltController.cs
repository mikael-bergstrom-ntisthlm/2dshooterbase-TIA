using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltController : MonoBehaviour
{
  float speed = 3f;

  void Start()
  {

  }

  void Update()
  {
    Vector2 movement = new Vector2(0, speed) * Time.deltaTime;

    transform.Translate(movement);

  }
}
