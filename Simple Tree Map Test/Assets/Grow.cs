using UnityEngine;


public class Grow : MonoBehaviour {

    public SliderControl scaleSliderControl;
    public SliderControl rotationSliderControl;
    public float minScale = 1;
    public float maxScale = 100;
    
    void Start()
    {
        transform.localScale = Vector3.one * minScale;
        scaleSliderControl.OnValueChanged += SetScaleValue;
        rotationSliderControl.OnValueChanged += SetRotationValue;
    }

    private void SetScaleValue(float value)
    {
		transform.localScale = Vector3.one * (minScale + (maxScale - minScale) * value* value* value* value* value* value* value);
    }

    private void SetRotationValue(float value)
    {
        transform.localRotation = Quaternion.Euler(0, value * 360, 0);
    }
}
