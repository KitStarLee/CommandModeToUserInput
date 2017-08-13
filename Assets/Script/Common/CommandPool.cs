using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandPool : MonoBehaviour {

	delegate void CommandConversion(ObjectBase playObj);
	Dictionary<CommandType, CommandConversion> CommandRoute = new Dictionary<CommandType, CommandConversion>();

	public CommandStream commandStream;
	protected Dictionary<ObjectBase, List<CommandStream>> commandRecord;

	// Use this for initialization
	void Start () {

		commandStream = new CommandStream ();
		commandRecord = new Dictionary<ObjectBase, List<CommandStream>> ();


		CommandConversion Do_FrieCommand = (ObjectBase playObj) => {
		
			FrieCommand frie = new FrieCommand();
			frie.Execute (playObj);
			commandRecord [playObj].Add (frie);
		};

		CommandConversion Do_EludeCommand = (ObjectBase playObj) => {

			EludeCommand elude = new EludeCommand();
			elude.Execute (playObj);
			commandRecord [playObj].Add (elude);
		};

		CommandConversion Do_JumpCommand = (ObjectBase playObj) => {

			JumpCommand jump = new JumpCommand();
			jump.Execute (playObj);
			commandRecord [playObj].Add (jump);
		};

		CommandConversion Do_SupplementCommand = (ObjectBase playObj) => {

			SupplementCommand supplement = new SupplementCommand();
			supplement.Execute (playObj);
			commandRecord [playObj].Add (supplement);
		};

		CommandConversion Do_WalkCommand = (ObjectBase playObj) => {

			WalkCommand walk = new WalkCommand();
			walk.Execute (playObj);
			commandRecord [playObj].Add (walk);
		};

		CommandRoute.Add (CommandType.EludeCommand, Do_EludeCommand);
		CommandRoute.Add (CommandType.FrieCommand, Do_FrieCommand);
		CommandRoute.Add (CommandType.JumpCommand, Do_JumpCommand);
		CommandRoute.Add (CommandType.SupplementCommand, Do_SupplementCommand);
		CommandRoute.Add (CommandType.WalkCommand, Do_WalkCommand);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ExecuteCommand(CommandType command, ObjectBase playObj)
	{
		if (commandStream == null || playObj == null)
			return;

		if (!commandRecord.ContainsKey (playObj)) {

			List<CommandStream> commandList = new List<CommandStream> ();
			commandRecord.Add (playObj, commandList);
		} else {
				
			if (commandRecord [playObj].Count > 10) {
			
				commandRecord [playObj].Clear ();    
			}
		
		}

		if (CommandRoute.ContainsKey (command)) {
		
			CommandRoute [command] (playObj);
		}
		


	}

	public void UndoCommand(ObjectBase playObj)
	{
		if (commandRecord.ContainsKey (playObj)) {

			if (commandRecord [playObj].Count > 1) {
				
				commandRecord [playObj] [commandRecord [playObj].Count - 2].Undo (playObj);
				commandRecord [playObj].RemoveAt(commandRecord [playObj].Count - 2);
			
			} else {
			
				Debug.Log ("无法撤回，撤回长度过界");
			}
		}
	}
}
