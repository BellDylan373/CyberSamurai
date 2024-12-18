using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Turret : MonoBehaviour
{
    #region Attributes
    [Header("Game OBJ")]
    [SerializeField] Attributes Attributes;
    [SerializeField] Bullet bullet;
    [SerializeField] projectileLauncher projectileLauncher;
    [SerializeField] float spawnTimer = 1f;
    private float timeSinceFired = 0;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {  
        timeSinceFired += Time.fixedDeltaTime;
        if(timeSinceFired >= spawnTimer)
        {
        FireProjectile();
        timeSinceFired = 0;
        }
    }
#region shooting script
        // create projectile over time
    public void FireProjectile()
    {

            projectileLauncher.launch();

        
    }
    void ShootCycle()
    {
        
    }
#endregion
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
             }
        }
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Open fire!!!");
        }
    }
    #endregion
}
