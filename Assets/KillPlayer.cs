﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
  private void OnTriggerEnter2D( Collider2D collision )
  {
    if ( collision.CompareTag( "Player" ) )
    {
      SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
  }
}
