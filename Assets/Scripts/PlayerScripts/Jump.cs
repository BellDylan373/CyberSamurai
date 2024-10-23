using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    #region Attributes 
    [Header("Jump")]
    [SerializeField]float jump;
    [SerializeField] bool isJumping;
    [Space(5)]

    private Rigidbody2D rb;
    #endregion
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    #region Jump  
        if(Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
        }
    }
        // check if touchground to reset jump
    void OnCollisionEnter2D(Collision2D other)
    {
        
    }

    #endregion
}
