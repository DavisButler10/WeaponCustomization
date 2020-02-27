using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAK : IAK
{
    float m_BasicAccuracy = 5.0f;
    float m_BasicAmmo = 0.0f;
    string prefabPath = "Body";
    public GameObject model; 

    public float GetAccuracy()
    {
        return m_BasicAccuracy;
    }

    public float GetAmmo()
    {
        return m_BasicAmmo;
    }

    public GameObject GetGameObject()
    {
        return model;
    }

    public BasicAK()
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
    }

    public BasicAK(Vector3 worldPos)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab, worldPos, prefab.transform.rotation);
    }
}
