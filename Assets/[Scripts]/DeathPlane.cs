using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;

[System.Serializable]
public class DeathPlane : MonoBehaviour
{
    public Transform playerSpawnPoint;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Respawn(collision.gameObject);
        }
    }

    public void Respawn(GameObject go)
    {
        go.transform.position = playerSpawnPoint.position;
    }    
}
