using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EludeCommand : CommandStream {

	public bool isElude = false;
	public int eludeNumber = 0;   //躲避次数
	// public AnimationClip eludeAnimation;  //躲避动画

	public EludeCommand():base()
	{
		commandType = CommandType.EludeCommand;
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
		
			tagerObj.Elude (this);
		}
	}
}
