using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneTrans1 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
             Debug.Log("and AWAY we go!");
             SceneManager.LoadScene("Stage1");
            
        }
    }
}
