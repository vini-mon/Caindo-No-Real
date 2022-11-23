using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUp/SpeedUp")]
public class SpeedUp : PowerUpEffect
{
    public int amount;
    public override void Apply(GameObject target){
        target.GetComponent<movimentation>().speed += amount;
    }
}
