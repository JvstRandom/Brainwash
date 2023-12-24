using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectThatIsAlive : MonoBehaviour {

	public static ObjectThatIsAlive Instance { get; private set; }

	private void Awake()
	{
        DontDestroyOnLoad(gameObject);
		Instance = this;
	}
	public Vector3 GetCurrentPosition(){
		return transform.position;
	}
}