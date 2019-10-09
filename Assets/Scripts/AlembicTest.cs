using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UTJ.Alembic;

public class AlembicTest : MonoBehaviour
{
	AlembicStreamPlayer _alembic;


	void Start()
	{
		_alembic = gameObject.GetComponent<AlembicStreamPlayer>();
	}

	void Update()
	{
		if (Input.GetKeyDown("s"))
		{
			StartCoroutine ( _StartAnimation ());
		}
	}

	IEnumerator _StartAnimation()
	{
		float time =(float) _alembic.startTime;
		
		while (true)
		{
			// if ((float)_alembic.endTime <= time)
			if ((float)2.0f <= time)
			{
				yield break; 
			}
			_alembic.currentTime = time;
			time += 0.02f;
			yield return null; 
		}
	}
}
