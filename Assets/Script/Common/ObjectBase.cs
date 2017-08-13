using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public virtual void Elude(EludeCommand command)
	{
		Debug.Log ("躲避...");
	}

	public virtual void Frie(FrieCommand command)
	{
		Debug.Log ("开火...");
	}

	public virtual void Jump(JumpCommand command)
	{
		Debug.Log ("跳...");
	}

	public virtual void Supplement(SupplementCommand command)
	{
		Debug.Log ("补充能量...");
	}

	public virtual void Walk(WalkCommand command)
	{
		Debug.Log ("行走...");
	}
}
