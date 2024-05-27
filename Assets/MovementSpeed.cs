using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSpeed : Collectible
{
    public override void Collected(StarterAssets.FirstPersonController player)
    {
        player.MoveSpeed += 3;
    }
}
