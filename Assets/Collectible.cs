using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public virtual void Collected(StarterAssets.FirstPersonController player)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger");
        Collected(other.gameObject.GetComponent<StarterAssets.FirstPersonController>());
        Destroy(gameObject);

    }
}
