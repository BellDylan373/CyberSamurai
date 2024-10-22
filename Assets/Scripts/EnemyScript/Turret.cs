using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Turret : MonoBehaviour
{
    #region Attributes
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
        fireProjectile();
        timeSinceFired = 0;
        }
    }

        // create projectile over time
        public void fireProjectile()
    {

            projectileLauncher.launch();

        
    }
}
