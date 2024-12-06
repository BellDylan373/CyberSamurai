using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    [SerializeField] int health = 40;
    [SerializeField] int maxhealth =40;
void FixedUpdate()
    {
        if(health == 0){
            Destroy(this.gameObject);
            
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
         if(other.gameObject.CompareTag("Bullet")){
            Debug.Log("boom");
            health -= 20;
            Destroy(other.gameObject);
        }
    }

}
