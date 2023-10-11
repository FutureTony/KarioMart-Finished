using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerupps/SpeedBuff")]
public class SpeedBuff : PowerupEffects
{
    public float amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerController>().maxSpeed += amount;
        // we made it
    }
}
