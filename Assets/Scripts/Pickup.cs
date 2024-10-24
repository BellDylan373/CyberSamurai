using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
#region Attributes
[Header("Attributes")]
 [SerializeField] public bool isHealth;
 [SerializeField] public bool isFreeLife;
 [SerializeField] public float healthGain;
 [SerializeField] public float livesGain;

 #endregion
}
