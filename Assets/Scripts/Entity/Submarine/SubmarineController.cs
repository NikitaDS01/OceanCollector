using UnityEngine;

public class SubmarineController
{
    private float _depth;
    private Vector2 _position;

    public SubmarineController(float depth, Vector2 position)
    {
        this._depth = depth;
        this._position = position;
    }

    public float Depth => this._depth;
    public Vector2 Position => this._position;
    public string GetTextUI()
    {
        return string.Format("Depth:{0} Position:({1} {2})",
            this.Depth,
            this.Position.x,
            this.Position.y
            );
    }
}