using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private const int TurnSpeed = 120;
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
      transform.RotateAround( point, axis, Time.deltaTime * TurnSpeed );
    }
    if ( rightInput )
    {
      Vector3 axis = new Vector3( 0, 0, -1 );
      transform.RotateAround( point, axis, Time.deltaTime * TurnSpeed );
    }
  }
}
