using Godot;
using System;

public class labda : Node2D
{
    public AudioStreamPlayer2D ballboing;
    public Random rnd; 
    public int motion;
    public override void _Ready()
	{
        motion = 15;
		rnd = new Random();
        ballboing = GetNode("../ballboing") as AudioStreamPlayer2D;
	}
	private void _on_RigidBody2D_input_event(object viewport, object inputEvent, int shape_idx){
		if (inputEvent is InputEventMouseButton egeraction){
			if(egeraction.Pressed && egeraction.ButtonIndex == 1){
                var labda = (RigidBody2D)GetNode("RigidBody2D");
                int rpos1 = rnd.Next(0, 500);
                int rpos2 = rnd.Next(0, 500);
                Vector2 pos = new Vector2(rpos1, rpos2);
                Vector2 pos2 = new Vector2(0, 0);
                labda.ApplyImpulse(pos2, pos);
                ballboing.Play();
			}
		}
	}
}

