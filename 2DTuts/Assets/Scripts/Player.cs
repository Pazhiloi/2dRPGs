using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public static Player instance;
  [SerializeField] private int moveSpeed = 1;
  [SerializeField] private Rigidbody2D playerRigidbody;
  [SerializeField] private Animator playerAnimator;

  public string transitionName;
  void Start()
  {
    SingletonInit();
    DontDestroyOnLoad(this);
  }

  private void SingletonInit()
  {
    if (instance != null && instance != this)
    {
      Destroy(this.gameObject);

    }
    else
    {
      instance = this;
    }
  }

  void Update()
  {
    float horizontalMovement = Input.GetAxisRaw("Horizontal");
    float verticalMovement = Input.GetAxisRaw("Vertical");

    playerRigidbody.velocity = new Vector2(horizontalMovement, verticalMovement) * moveSpeed;

    playerAnimator.SetFloat("movementX", playerRigidbody.velocity.x);
    playerAnimator.SetFloat("movementY", playerRigidbody.velocity.y);

    if (horizontalMovement == 1 || horizontalMovement == -1 || verticalMovement == 1 || verticalMovement == -1)
    {
      playerAnimator.SetFloat("lastX", horizontalMovement);
      playerAnimator.SetFloat("lastY", verticalMovement);
    }

  }
}
