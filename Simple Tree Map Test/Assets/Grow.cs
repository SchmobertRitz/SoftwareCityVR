using UnityEngine;


public class Grow : MonoBehaviour {

    public SliderControl sliderControl;
    public float minScale = 1;
    public float maxScale = 100;
    
    void Start()
    {
        transform.localScale = Vector3.one * minScale;
        sliderControl.OnValueChanged += SetValue;
    }

    private void SetValue(float value)
    {
        transform.localScale = Vector3.one * (minScale + (maxScale - minScale) * value);
    }
}
