using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : CommandStream {

	public JumpCommand():base()
	{
		commandType = CommandType.JumpCommand;
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

			tagerObj.Jump (this);
		}
	}
}
