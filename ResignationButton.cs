using Godot;
using System;

public partial class ResignationButton : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.ButtonUp += () => ((Game)GetParent()).Resign();
	}
}
