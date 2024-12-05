using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneSpawn : MonoBehaviour
{
 #region Variables
  [Header("prefab/helper")]
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Transform spawnTransform;
    [Header("config")]
    [SerializeField] float projectileSpeed;



#endregion
    void Start()
    {
        
    }
    //launch projectiles
    public void launch()
    {
        GameObject newProjectile = Instantiate(projectilePrefab, spawnTransform.position, Quaternion.identity);
        newProjectile.GetComponent<Rigidbody2D>().velocity = transform.up * projectileSpeed;

         Destroy(newProjectile,2);
    }

}
