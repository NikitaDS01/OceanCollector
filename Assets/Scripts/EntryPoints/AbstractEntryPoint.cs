using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class AbstractEntryPoint : MonoBehaviour
{
    private List<IContainEvent> _containEvents;
    private EventBus _eventBus;
    protected IReadOnlyList<IContainEvent> ContainEvents => this._containEvents;
    protected EventBus EventBus => this._eventBus;

    private void Awake()
    {
        this._containEvents = new List<IContainEvent>();
        this._eventBus = new EventBus(false);

        this.Registry();
        this.Init();
        this.Enable();
    }

    private void OnDestroy()
    {
        this.Disposable();
    }
    protected abstract void Registry();
    protected abstract void Init();
    protected virtual void Enable()
    {
        foreach (var item in _containEvents)
            item.EnableEvent();
    }
    protected virtual void Disposable()
    {
        foreach (var item in _containEvents)
            item.DisableEvent();
    }
}