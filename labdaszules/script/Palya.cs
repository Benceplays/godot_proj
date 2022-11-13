using Godot;
using System;

public class Palya : Node2D
{
    [Export]
    public PackedScene psLabda;
    [Export]
    public PackedScene psLufi;
    [Export]
    public PackedScene psKalapacs;
    public Label fps;
    Random rnd;
    public override void _Ready()
    {
        Engine.TimeScale = 2;
        fps = GetNode("Label") as Label;
        rnd = new Random();
        
    }
    public override void _Input(InputEvent esemeny)
    {
            if (Input.IsActionJustPressed("labda_keszites")){
            Node2D labda = (Node2D)psLabda.Instance();
            labda.Position = GetLocalMousePosition();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            labda.Modulate = Color.Color8((byte)r, (byte)g, (byte)b);
            AddChild(labda);
            }
            if (Input.IsActionJustPressed("lufi_keszites")){
            Node2D lufi = (Node2D)psLufi.Instance();
            lufi.Position = GetLocalMousePosition();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            lufi.Modulate = Color.Color8((byte)r, (byte)g, (byte)b);
            AddChild(lufi);
            }
            if (Input.IsActionJustPressed("kalapacs_keszites")){
            Node2D kalapacs = (Node2D)psKalapacs.Instance();
            kalapacs.Position = GetLocalMousePosition();
            AddChild(kalapacs);
            }
            if (Input.IsActionJustPressed("back")){
                GetTree().ChangeScene("res://Menu.tscn");
            }
    }
    public override void _Process(float delta)
    {
        fps.Text = $"{1 / delta} FPS";
    }
}
