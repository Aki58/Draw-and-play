using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemController : MonoBehaviour {

	// Use this for initialization

	public Animator anim;
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		anim = GetComponent<Animator>();
	}

	public void GolemActions(string ActionCommands)
	{
		ActionCommands = ActionCommands.Trim();
        switch (ActionCommands)
		{
          case "jump":
		   anim.Play("jump",-1,0f);
		   break;
		  case "hit":
		   anim.Play("hit",-1,0f);
		   break;
          case "walk":
           anim.Play("walk", -1, 0f);
           break;
          case "rage":
           anim.Play("rage", -1, 0f);
           break;
          case "land":
           anim.Play("land", -1, 0f);
           break;
          case "damage":
           anim.Play("damage", -1, 0f);
           break;
          default:
		   anim.Play("idle",-1,0f);
		   break; 

		}
        

	}
}
