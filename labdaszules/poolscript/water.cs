using Godot;
using System;
using System.Threading;

public class water : Node2D
{
	[Export]public PackedScene psWater;
	public Label fps;
	public int pattanas =  30;
	public int szama = 0;
	public override void _Ready(){
		fps = GetNode("Label") as Label;
		Engine.TimeScale = 0.5f;
	}
	public override void _Input(InputEvent esemeny){
		if (Input.IsActionJustPressed("back")){
			GetTree().ChangeScene("res://Menu.tscn");
		}
	}
	public override void _Process(float delta){
		fps.Text = $"{1 / delta} FPS";
	}
	public override void _PhysicsProcess(float delta){
		while (szama != 50){
			Node2D water = (Node2D)psWater.Instance();
			Vector2 waterpos = new Vector2(234, 158);
			water.Position = waterpos;
			AddChild(water);  
			szama++; 
		}
	}
	private void _on_Area2D_body_entered(RigidBody2D body)
	{
		body.ApplyCentralImpulse(new Vector2(0, -pattanas * 9 - pattanas));
	}
	private void _on_Area2D_body_exited(RigidBody2D body)
	{
		body.ApplyCentralImpulse(new Vector2(0, pattanas * 9 + pattanas));
	}
}

