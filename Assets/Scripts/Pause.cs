using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] float count = 3f;
    [SerializeField] simpMove playerMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Time.timeScale =0;
        }
         if(Input.GetKeyDown(KeyCode.P) )
        {
            Time.timeScale =1;
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Time.timeScale = Time.timeScale/2;
            
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            Time.timeScale =Time.timeScale*2;
        }
    }
}
