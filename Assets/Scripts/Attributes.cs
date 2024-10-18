using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    #region Attributes
    [SerializeField] bool isPlayer;
    [SerializeField] bool isDead;
    [SerializeField] float health;
    [SerializeField] float energy;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         Death();
    }
    #region Health mechanics
    void CheatDeath()
    {
        if(isPlayer == true &&  health <= 10 && health > 0 )
        {
            health = 1;
        }
    }
    void Death()
    {
        if(health <= 0)
        {
            isDead = true;
        }
        if(isDead == true)
        {
            Debug.Log("poof");
            Destroy(this);
        }
    }
    #endregion
}
