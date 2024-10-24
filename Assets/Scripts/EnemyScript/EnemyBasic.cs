using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
      #region Attributes
    [Header("Game OBJ")]
    [SerializeField] Attributes Attributes;
    [SerializeField] Bullet bullet;
    [SerializeField] projectileLauncher projectileLauncher;
    [SerializeField] GameObject pickUpPrefab;
    [SerializeField] Transform spawnTransform;
    [SerializeField] float spawnTimer = 1f;
    private float timeSinceFired = 0;
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
         if(other.gameObject.CompareTag("BulletFriendly"))
        {
             Debug.Log("bang!");
            Destroy(other.gameObject);
             Attributes.health -= bullet.bulletDamage;
             if(Attributes.health <= 0){
                Debug.Log("poof");
                Destroy(this.gameObject);
                GameObject newPickup = Instantiate(pickUpPrefab, spawnTransform.position, Quaternion.identity);
             }
        }

    }
    #endregion
}
