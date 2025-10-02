using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{
  [SerializeField] string transitionAreaName;

  private void Start() {
    if (transitionAreaName == Player.instance.transitionName)
    {
      Player.instance.transform.position = transform.position;
    }
  }
}
