using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupplementCommand : CommandStream {

	public SupplementCommand():base()
	{
		commandType = CommandType.SupplementCommand;
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

			tagerObj.Supplement (this);
		}
	}
}
