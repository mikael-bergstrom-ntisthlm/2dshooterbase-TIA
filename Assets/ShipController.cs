using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Skjutande
 * Hindra att man åker utanför
 * Fiender
 - (Diagonal förflyttning)
 - Musik
 - Livräkning & gameover
 - Highscore 
 - Powerups (speed, vapen)

 SKOTT:
 x Åka uppåt
 - Ta bort när ovanför skärmen
 - Skapa där skeppet är
 - Inte skjuta varje frame
 - Skada fiender + ta bort
*/

public class ShipController : MonoBehaviour
{

  [SerializeField]
  float speed = 1f;

  void Start()
  {

  }

  void Update()
  {
    // 30fps = 30*0.02 = 0.6
    // 60fps = 60*0.02 = 1.2
    // 120fps = 120*0.02 = 2.4

    float xMove = Input.GetAxisRaw("Horizontal");
    float yMove = Input.GetAxisRaw("Vertical");

    Vector2 movement = new Vector2(xMove, yMove) * speed * Time.deltaTime;

    transform.Translate(movement);
  }
}
