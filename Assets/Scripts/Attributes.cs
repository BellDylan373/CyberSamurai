using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Attributes : MonoBehaviour
{
    #region Attributes
    [SerializeField] Bullet bullet;
    [SerializeField] public bool isPlayer;
    [SerializeField] public bool isDead;
    [SerializeField] public bool cheatingDeath = true;
    [SerializeField] public float health;
    [SerializeField] public float energy;
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
 
    void Death()
    {
        if(health <= 0)
        {
            isDead = true;
        }
        if(isDead == true  && isPlayer)
        {
            Debug.Log("poof");
            SceneManager.LoadScene("SampleScene");
        }
    }
    
    #endregion
}
