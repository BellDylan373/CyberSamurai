using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
#region attributes
    [SerializeField] public GameObject player;
    [SerializeField] public GameObject respawnPoint;
#endregion
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Collisions
      void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Get over Here!");
         player.transform.position = respawnPoint.transform.position;
        }
       
    }
    #endregion
}
