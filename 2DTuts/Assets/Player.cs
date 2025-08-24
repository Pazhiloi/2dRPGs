using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] private Rigidbody2D playerRigidbody;
    void Start()
    {
        
    }

    void Update()
    {
      float horizontalMovement = Input.GetAxisRaw("Horizontal");
      float verticalMovement = Input.GetAxisRaw("Vertical");
        playerRigidbody.velocity = new Vector2 (horizontalMovement, verticalMovement);
    }
}
