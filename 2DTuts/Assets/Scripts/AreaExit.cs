using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
 [SerializeField] private string sceneToLoad;
 [SerializeField] private string transitionAreaName;
 [SerializeField] private AreaEnter theAreaEnter;
 
 private void Start() {
    theAreaEnter.transitionAreaName = transitionAreaName;
 }
    private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
      Player.instance.transitionName = transitionAreaName;
      SceneManager.LoadScene(sceneToLoad);
    }
  }
}
