using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : ObjectBase {

	public string userName; //用户姓名

	void Awake ()
	{
		this.transform.name = userName;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}
