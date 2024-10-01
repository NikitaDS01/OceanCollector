using UnityEngine;

public class PlayerController
{
    private AbstractMovePlayer _movePlayer;

    public PlayerController(AbstractMovePlayer movePlayer)
    {
        this._movePlayer = movePlayer;
    }
}
