using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHeight : Collectible
{
    public override void Collected(StarterAssets.FirstPersonController player)
    {
        player.JumpHeight += 3;
    }
}
