using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public bool playerInRange;

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        playerInRange = true;
        // Debug.Log("Player in range: " + collisionInfo);

    }
}
