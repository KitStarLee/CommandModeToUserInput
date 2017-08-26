using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkCommand : CommandStream {

	public WalkCommand( ):base()
	{
		commandType = CommandType.WalkCommand;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	protected override void PlayExecute (CommandStream command)
	{
		if (command != null) {

			tagerObj.Walk (this);
		}
	}
}
