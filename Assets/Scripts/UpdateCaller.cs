using System;
using UnityEngine;

public class UpdateCaller : MonoBehaviour
{
    private static UpdateCaller instance;

    private Action<float> updateCallback;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public static void AddUpdateCallback(Action<float> updateMethod)
    {
        instance.updateCallback += updateMethod;
    }

    private void Update()
    {
        updateCallback(Time.deltaTime);
    }
}
