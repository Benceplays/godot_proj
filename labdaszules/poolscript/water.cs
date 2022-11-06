using Godot;
using System;
using System.Threading;

public class water : Node2D
{
    [Export]
    public PackedScene psWater;
    public Label fps;
    public int szama = 0;
    public override void _Ready()
    {
        fps = GetNode("Label") as Label;
        Engine.TimeScale = 0.5f;
    }
    public override void _Input(InputEvent esemeny){
        if (Input.IsActionJustPressed("back")){
            GetTree().ChangeScene("res://Menu.tscn");
        }
    }
    public override void _Process(float delta)
    {
        fps.Text = $"{1 / delta} FPS";
    }
    public override void _PhysicsProcess(float delta){
        while (szama != 500){
            Node2D water = (Node2D)psWater.Instance();
            Vector2 waterpos = new Vector2(487, 158);
            water.Position = waterpos;
            AddChild(water);  
            szama++; 
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
