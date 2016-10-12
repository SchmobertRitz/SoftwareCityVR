using UnityEngine;
using System.Collections;

public class LifeCycle : MonoBehaviour {

    public delegate void OnBegin();
    public delegate void OnFinish();

    public OnBegin OnBeginHandler;
    public OnFinish OnFinishHandler;

    void Start()
    {
        Begin();
    }

    public void Begin()
    {
        OnBeginHandler();
    }

    public void Finish()
    {
        OnFinishHandler();
    }
}
