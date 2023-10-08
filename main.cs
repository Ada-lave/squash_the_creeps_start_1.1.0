using Godot;
using System;

public partial class main : Node
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	public PackedScene MobScene{get; set;}


	private void OnMobTimerTimeout()
	{
		Mob mob = MobScene.Instantiate<Mob>();

		var mobSpawnLocation = GetNode<PathFollow3D>("SpawnPath/SpawnLocation");

		mobSpawnLocation.ProgressRatio = GD.Randf();

		Vector3 playerPosition = GetNode<player1>("Player").Position;
		mob.Initialize(mobSpawnLocation.Position, playerPosition);

		AddChild(mob);
	}
}
