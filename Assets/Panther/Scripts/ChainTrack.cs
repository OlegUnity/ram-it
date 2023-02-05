using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainTrack : MonoBehaviour {

	public float mSpeed = 1.0f;
	public float mTrackSpeed = 1.0f;

	public List<Transform> mWheels;
	public List<float> mWheelSpeed;

	public Renderer mTrack;


	void Start ()
	{
		if ( mWheels.Count != mWheelSpeed.Count )
			Debug.Log( "ChainTrack : setup error 0" );

		for ( int i = 0; i < mWheelSpeed.Count; i++ )
		{
			if ( mWheelSpeed[ i ] == 0.0f  )
				Debug.Log( "ChainTrack : setup error 1" );
		}
	}

	void Update ()
	{
		Vector2 offset = Vector2.zero;
		
		offset = mTrack.material.mainTextureOffset;
		offset.x += mTrackSpeed * Time.deltaTime;
		mTrack.material.mainTextureOffset = offset;

		for ( int i = 0; i < mWheels.Count; i++ )
		{
			mWheels[ i ].transform.Rotate( 0.0f, 0.0f, Time.deltaTime * mWheelSpeed[ i ] * mSpeed );
		}

	}

}
