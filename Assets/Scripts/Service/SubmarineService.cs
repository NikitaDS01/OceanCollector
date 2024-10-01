public class SubmarineService : IService, IContainEvent
{
    private readonly SubmarineComponent _playerComponent;
    private readonly SubmarineController _playerController;

    public SubmarineService(
        SubmarineComponent playerComponent, SubmarineController playerController
    )
    {
        this._playerComponent = playerComponent;
        this._playerController = playerController;
    }

    /// <summary>
    /// 
    /// </summary>
    public SubmarineController Controller => this._playerController;

    /// <summary>
    /// Компонент игрока для работы с Unity
    /// </summary>
    public SubmarineComponent UnityComponent => this._playerComponent;

    public void DisableEvent()
    {
        throw new System.NotImplementedException();
    }

    public void EnableEvent()
    {
        throw new System.NotImplementedException();
    }
}
}
