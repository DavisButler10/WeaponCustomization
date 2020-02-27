using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class AKDecorator : IAK
{
    protected IAK m_DecoratedRifle;

    public AKDecorator(IAK rifle)
    {
        m_DecoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return m_DecoratedRifle.GetAccuracy();
    }

    public virtual float GetAmmo()
    {
        return m_DecoratedRifle.GetAmmo();
    }

    public virtual GameObject GetGameObject()
    {
        return m_DecoratedRifle.GetGameObject();
    }
}

public class WithReflexSight : AKDecorator
{
    float m_ScopeAccuracy = 20.0f;
    string prefabPath = "ReflexSight";
    GameObject model; 

    public WithReflexSight(IAK rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ScopeAccuracy;
    }
}

public class WithStock : AKDecorator
{
    float m_StockAccuracy = 5.0f;
    string prefabPath = "Stock";
    GameObject model; 

    public WithStock(IAK rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_StockAccuracy;
    }
}

public class WithGrip : AKDecorator
{
    float m_GripAccuracy = 10.0f;
    string prefabPath = "Grip";
    GameObject model;

    public WithGrip(IAK rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_GripAccuracy;
    }
}

public class WithSilencer : AKDecorator
{
    float m_SilencerAccuracy = 2.0f;
    string prefabPath = "Silencer";
    GameObject model;

    public WithSilencer(IAK rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_SilencerAccuracy;
    }
}

public class WithDrum : AKDecorator
{
    float m_DrumAmmo = 70.0f;
    string prefabPath = "Mag_Drum";
    GameObject model;

    public WithDrum(IAK rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAmmo()
    {
        return base.GetAmmo() + m_DrumAmmo;
    }
}