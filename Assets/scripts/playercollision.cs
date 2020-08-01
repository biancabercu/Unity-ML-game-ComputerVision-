using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//rigid body + collider
//GameObject.FindGameObjectsWithTag("Respawn"); //find object by tag
//punem tag florilor
public class playercollision : MonoBehaviour
{
    public Character_Animations_Human movement;

    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.name == "flower05") {
           movement.enabled = false;
            Debug.Log("++++++++++++++++++-----------------------" + collisionInfo.collider.name);
        }
        if (collisionInfo.collider.tag == "5") {
            Debug.Log("avem tag 5==============================");
        }
        if (collisionInfo.collider.tag == "3") {
            Debug.Log("avem tag 3==============================");
        }
        if (collisionInfo.collider.tag == "2") {
            Debug.Log("avem tag 2==============================");
        }
        if (collisionInfo.collider.tag == "1") {
            Debug.Log("avem tag 1==============================");
        }
        if (collisionInfo.collider.tag == "6") {
            Debug.Log("avem tag 6==============================");
        }
    }
    
}
