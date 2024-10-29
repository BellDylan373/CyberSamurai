using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Respawn respawn;
    [SerializeField] GameObject checkpoint;
    [SerializeField] bool checkpointVisited = false;
    void Start()
    {
       respawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Respawn>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Collisions
      void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && checkpointVisited == false)
        {
            Debug.Log("CheckPoint HE HA!!");
            respawn.respawnPoint.transform.position = checkpoint.transform.position;
            checkpointVisited = true;
        }
       
    }
    #endregion
}
