using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс сервис для получения доступа к
/// Unity компоненту и контроллеру
/// игрока
/// </summary>
public class PlayerService : IService, IContainEvent
{
    private readonly PlayerComponent _playerComponent;
    private readonly PlayerController _playerController;

    public PlayerService(
        PlayerComponent playerComponent, PlayerController playerController
    )
    {
        this._playerComponent = playerComponent;
        this._playerController = playerController;
    }

    /// <summary>
    /// 
    /// </summary>
    public PlayerController Controller => this._playerController;

    /// <summary>
    /// Компонент игрока для работы с Unity
    /// </summary>
    public PlayerComponent UnityComponent => this._playerComponent;

    public void DisableEvent()
    {
        throw new System.NotImplementedException();
    }

    public void EnableEvent()
    {
        throw new System.NotImplementedException();
    }
}
