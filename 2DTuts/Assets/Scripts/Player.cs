using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] private Rigidbody2D playerRigidbody;
  [SerializeField] private Animator playerAnimator;
    void Start()
    {
        
    }

  void Update()
  {
    float horizontalMovement = Input.GetAxisRaw("Horizontal");
    float verticalMovement = Input.GetAxisRaw("Vertical");
    
    playerRigidbody.velocity = new Vector2(horizontalMovement, verticalMovement);

    playerAnimator.SetFloat("movementX", playerRigidbody.velocity.x);
    playerAnimator.SetFloat("movementY", playerRigidbody.velocity.y);

    if (horizontalMovement == 1 || horizontalMovement == -1 || verticalMovement == 1 || verticalMovement == -1)
    {
      playerAnimator.SetFloat("lastX", horizontalMovement);
      playerAnimator.SetFloat("lastY", verticalMovement);
    }
    
  }
}
