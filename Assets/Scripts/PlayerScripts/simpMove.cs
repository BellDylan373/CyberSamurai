using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class simpMove : MonoBehaviour
{
    #region attributes
    [Header("Game OBJ")]
    [SerializeField] Attributes Attributes;
    [SerializeField] Bullet bullet;
    [SerializeField] Hazard hazard;
    [SerializeField] Pickup pickup;
    [Header("movement")]
    [SerializeField] float move;
    [SerializeField] float speed;
    [SerializeField] bool IsFacingRight;
    [Space(5)]
    [Header("Wall Slide")]
    [SerializeField] bool isWallSliding;
    [SerializeField] float wallSlideSpeed = 2f;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask wallLayer;
    [Space(5)]
    [Header("Weapons")]
    [SerializeField] projectileLauncher projectileLauncher;
     [Space(5)]
    [Header("Jump")]
    [SerializeField]float jump;
    [SerializeField] bool isJumping;
  
    private Vector2 moveInput;
    private Rigidbody2D rb;
   
    #endregion
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
                if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            fireProjectile();
            
        }
        #region Jump  
        if(Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
        }
    }
        // check if touchground to reset jump


    #endregion
    
    void FixedUpdate()
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
        projectileLauncher.AimGun(Camera.main.ScreenToWorldPoint(Input.mousePosition));
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
        if(IsWall() && move != 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, -wallSlideSpeed, float.MaxValue));
        }
    }
  #region Weapon functions
    public void fireProjectile()
    {
        projectileLauncher.launch();
    }




  #endregion
  #region Collisions
      void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
             Debug.Log("hmmmm yes this ground is made of ground.");
            isJumping = false;
        }
         if(other.gameObject.CompareTag("Bullet"))
        {
             Debug.Log("bang!");
             Destroy(other.gameObject);
             Attributes.health -= bullet.bulletDamage;
        }
                 if(other.gameObject.CompareTag("Pickup"))
        {
             Debug.Log("goodies!");
             Destroy(other.gameObject);
             if(pickup.isHealth == true)
             {
                Attributes.health += pickup.healthGain;
             }
        }
    }
    #endregion
}
