using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Create new playerdata obj allowing access to player data through right
//click create ->player->playerdata
[CreateAssetMenu(menuName = "Player Data")]

public class PlayerData : MonoBehaviour
{
#region Movement Variables
    [Header("Gravity")]
    [Space(5)]
    // set gravity for max jump height
    [HideInInspector] public float gravityStr;
    //strength of downwards pull
    [HideInInspector] public float gravityScale;
    // increase for downwards inputs
    public float gravityFallMultiplier;
    //terminal velocity
    public float maxFallSpeed;

    [Space(15)]
    [Header("Movement Attributes")]
    [Space(5)]
    //set max speed
    public float moveMaxSpeed;
    //time to reach speed
    public float moveAcceleration;
    [HideInInspector] public float moveAccelAmount;
    public float moveDeceleration;
    [HideInInspector] public float moveDeccelAmount;
    [Range(0f, 1)] public float accelInAir;
    [Range(0f, 1)] public float decelInAir;

    [Space(15)]
    [Header("Jump Attributes")]
    //jump height
    public float jumpHeight;
    //time to reach apex
    public float jumpTimeToApex;
    //force applied upwards
    [HideInInspector] public float jumpForce; 
#endregion





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
