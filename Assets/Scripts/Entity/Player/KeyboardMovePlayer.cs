using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class KeyboardMovePlayer : AbstractMovePlayer
{
    public KeyboardMovePlayer(
        Rigidbody2D rigidbody, Transform transform,
        float speed, bool isRight = false
        ) : base(rigidbody, transform, speed, isRight)
    { }

    public override TypeMove Type => TypeMove.Keyboard;

    public override void Move()
    {
        float direction = this.GetAxis();
        this.Flip(direction);
        this.rigidbody.velocity = new Vector2(direction * this.Speed, 0);
    }
    public float GetAxis()
    {
        if (Input.GetKey(KeyCode.D))
            return 1f;
        if (Input.GetKey(KeyCode.A))
            return -1f;
        return 0;
    }
}