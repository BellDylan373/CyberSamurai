using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpMove : MonoBehaviour
{
    [SerializeField] float move;
    [SerializeField] float speed;
    [SerializeField] bool IsFacingRight;
    [Space(5)]
    [Header("Wall Slide")]
    [SerializeField] bool isWallSliding;
    [SerializeField] float wallSlideSpeed = 2f;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask wallLayer;
  
    private Vector2 moveInput;
    private Rigidbody2D rb;
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        #region Basic Movement
        move = Input.GetAxis("Horizontal");
        moveInput.x = move;
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (rb.velocity.x != 0)
		{
        	CheckDirectionToFace(moveInput.x > 0);
        }
        WallSlide();

        #endregion
        
    }
    
    private void Turn()
	{
		//stores scale and flips the player along the x axis, 
		Vector3 scale = transform.localScale; 
		scale.x *= -1;
		transform.localScale = scale;

		IsFacingRight = !IsFacingRight;
	}
      public void CheckDirectionToFace(bool isMovingRight)
	{
		if (isMovingRight != IsFacingRight)
			Turn();
	}
        // returns bool to check if touch wall
    private bool IsWall()
    {
        return Physics2D.OverlapCircle(wallCheck.position,0.2f, wallLayer);
    }
    // 
    private void WallSlide()
    {
        if(IsWall() )
        {
            isWallSliding = true;
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, -wallSlideSpeed, float.MaxValue));
        }else
        {
            isWallSliding = false;
        }
    }
}
