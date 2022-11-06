using Godot;
using System;

public class kalapacs : Node2D
{
	Random rnd;
	public override void _Ready()
	{
		rnd = new Random();
	}
	public void _on_RigidBody2D_input_event(object viewport, object inputEvent, int shape_idx){
		if (inputEvent is InputEventMouseButton egeraction){
			if(egeraction.Pressed && egeraction.ButtonIndex == 1){
				var kalapacs = (RigidBody2D)GetNode("RigidBody2D");
				int r = rnd.Next(0, 255);
				int g = rnd.Next(0, 255);
				int b = rnd.Next(0, 255);
				kalapacs.Modulate = Color.Color8((byte)r, (byte)g, (byte)b);
			}
		}
	}
}
