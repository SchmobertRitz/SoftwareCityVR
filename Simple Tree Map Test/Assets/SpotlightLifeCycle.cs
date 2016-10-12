using UnityEngine;
using System.Collections;

public class SpotlightLifeCycle : MonoBehaviour {

    private Light light;
    private Camera cam;
	
	void Start () {
        LifeCycle lifeCycle = FindObjectOfType<LifeCycle>();
        lifeCycle.OnBeginHandler += BeginInternal;
        lifeCycle.OnFinishHandler += FinishInternal;
        cam = FindObjectOfType<Camera>();
        light = GetComponentInChildren<Light>();
    }

    private void BeginInternal() {
        GetComponentInChildren<Animator>().SetBool("open", true);
    }


    private void FinishInternal()
    {
        GetComponentInChildren<Animator>().SetBool("open", false);
    }

    void Update()
    {
        float val = light.spotAngle / 100f;
        RenderSettings.ambientLight = new Color(0.01f + 0.2f * val, 0.01f + 0.2f * val, 0.02f + 0.4f * val);
        RenderSettings.fogColor = RenderSettings.ambientLight / 5;
        cam.backgroundColor = RenderSettings.fogColor;
    }

}
