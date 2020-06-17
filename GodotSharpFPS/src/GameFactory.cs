using Godot;
using GodotSharpFps.src.nodes;

public class GameFactory
{
    const string Path_PointProjectile = "res://game/projectiles/point_projectile.tscn";

    const string Path_ThrownSword = "res://game/projectiles/prj_thrown_sword.tscn";

    private Node _root;

    public GameFactory(Spatial root)
    {
        _root = root;
    }

    private Node SelectParent(bool addToTree, Node overrideParent)
    {
        Node parent = null;
        if (addToTree)
        {
            if (overrideParent != null)
            { parent = overrideParent; }
            else { parent = _root; }
        }
        return parent;
    }

    public PointProjectile SpawnPointProjectile(bool addToTree = true, Node overrideParent = null)
    {
        Node parent = SelectParent(addToTree, overrideParent);
        return ZqfGodotUtils.CreateInstance<PointProjectile>(Path_PointProjectile, parent);
    }

    public SwordThrowProjectile SpawnThrownSword(bool addToTree = true, Node overrideParent = null)
    {
        Node parent = SelectParent(addToTree, overrideParent);
        return ZqfGodotUtils.CreateInstance<SwordThrowProjectile>(Path_ThrownSword, parent);
    }
}
