using Godot;
using System;
using System.Threading;

public class lufi : Node2D
{
	public AudioStreamPlayer2D lufidurr;
	public override void _Ready()
	{
    lufidurr = GetNode("../Lufidurr") as AudioStreamPlayer2D;dsadasd

	}
	public void _on_RigidBody2D_input_event(object viewport, object inputEvent, int shape_idx){
		if (inputEvent is InputEventMouseButton egeraction){
			if(egeraction.Pressed && egeraction.ButtonIndex == 1){
				QueueFree();
				lufidurr.Play();
			}
		}
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
