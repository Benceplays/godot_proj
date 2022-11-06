using Godot;
using System;

public class lufi : Node2D
{
	public override void _Ready()
	{
		
	}
	public void _on_RigidBody2D_input_event(object viewport, object inputEvent, int shape_idx){
		if (inputEvent is InputEventMouseButton egeraction){
			if(egeraction.Pressed && egeraction.ButtonIndex == 1){
				RemoveChild(GetNode("RigidBody2D"));
			}
		}
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
