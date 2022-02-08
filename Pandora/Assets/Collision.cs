using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public bool playerInRange;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        playerInRange = true;
        Debug.Log("I am colliding");
        Debug.Log("Player in range: " + gameObject.tag);

    }
}
