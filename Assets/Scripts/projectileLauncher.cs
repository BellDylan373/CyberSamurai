using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class projectileLauncher : MonoBehaviour
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

    public void AimGun(Vector3 aimPosition)
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, aimPosition-transform.position);
    }
}
