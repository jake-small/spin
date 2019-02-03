using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  // Use this for initialization
  void Start()
  {

  }

  // Called once per frame just before any physics
  // Add custom physics here
  private void FixedUpdate()
  {
    var leftInput = Input.GetKey( "left" ) || Input.GetKey( "a" );
    var rightInput = Input.GetKey( "right" ) || Input.GetKey( "d" );
    if ( leftInput && rightInput )
    {
      return;
    }
    Vector3 point = new Vector3( 0, 0, 0 );

    if ( leftInput )
    {
      Vector3 axis = new Vector3( 0, 0, 1 );
      transform.RotateAround( point, axis, Time.deltaTime * 60 );
    }
    if ( rightInput )
    {
      Vector3 axis = new Vector3( 0, 0, -1 );
      transform.RotateAround( point, axis, Time.deltaTime * 60 );
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

}
