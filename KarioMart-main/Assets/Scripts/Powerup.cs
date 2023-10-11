using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public PowerupEffects PowerupEffects;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        PowerupEffects.Apply(collision.gameObject);
    }

}
