using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrieCommand : CommandStream {

	public FrieCommand():base()
	{
		commandType = CommandType.FrieCommand;
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

			tagerObj.Frie (this);
		}
	}
}
