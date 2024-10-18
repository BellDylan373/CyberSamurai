using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class projectileLauncher : MonoBehaviour
{  
    public void AimShip(Transform targetTransform)
    {
        transform.rotation =  Quaternion.LookRotation(Vector3.forward, targetTransform.position - transform.position);

    }
}
