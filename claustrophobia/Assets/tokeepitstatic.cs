using UnityEngine;
using System.Collections;

public class tokeepitstatic : MonoBehaviour {


	public GameObject handyman;


	void Start () {
		DontDestroyOnLoad(transform.gameObject);
	}

	public void setVisibility()
	{
//		handyman.renderer.enabled = false;
	}
}
