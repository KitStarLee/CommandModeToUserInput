using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CommandPool))]
public class UserInput : MonoBehaviour {

	CommandPool commandPool;

	public KeyCode frieCommand = KeyCode.Q;
	public KeyCode eludeCommand = KeyCode.W;
	public KeyCode jumpCommand = KeyCode.E;
	public KeyCode supplementCommand = KeyCode.R;
	public KeyCode walkCommand = KeyCode.T;

	public PlayerObject player;
	// Use this for initialization
	void Start () {
		
		commandPool = GetComponent<CommandPool> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (player == null)
			return;

		if (Input.GetKeyDown (frieCommand)) {
		
			commandPool.ExecuteCommand (CommandType.FrieCommand,player);
			Debug.Log ("---------");
		}
		if (Input.GetKeyDown (eludeCommand)) {

			commandPool.ExecuteCommand (CommandType.EludeCommand,player);
		}
		if (Input.GetKeyDown (jumpCommand)) {

			commandPool.ExecuteCommand (CommandType.JumpCommand,player);
		}
		if (Input.GetKeyDown (supplementCommand)) {

			commandPool.ExecuteCommand (CommandType.SupplementCommand,player);
		}
		if (Input.GetKeyDown (walkCommand)) {

			commandPool.ExecuteCommand (CommandType.WalkCommand,player);
		}
	}
}
