using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamRotator : MonoBehaviour
{
	public Vector3 mRotation;
	public Space mRelativeTo = Space.Self;

	public Camera mCamera;
	public Transform mTarget;

	void Update ()
	{
		transform.Rotate( mRotation * Time.deltaTime, mRelativeTo );

		if ( mCamera != null )
		{
			mCamera.transform.LookAt( mTarget );
		}
	}

}
