using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CommandType{

	EludeCommand,  //躲避
	FrieCommand,    //开火
	JumpCommand,    //跳
	SupplementCommand,    //补充
	WalkCommand,     //行走
	None        //kong
}

public class CommandStream  {

	protected CommandType commandType = CommandType.None;

	protected ObjectBase tagerObj; 


	public CommandStream()
	{  
		
	}

	public virtual void Execute(ObjectBase tagerObj)
	{
		if (tagerObj == null)
			return;

		this.tagerObj = tagerObj;

		PlayExecute (this);

	}

	public virtual void Undo(ObjectBase tagerObj)
	{
		if (this.tagerObj == null)
			return;
		
		PlayExecute (this);
	}

	protected virtual void PlayExecute(CommandStream command)
	{
		
	}

}
