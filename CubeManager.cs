using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CubeManager : MonoBehaviour
{
    private Cube myCube;

    public Slider heightSlider;
    public Slider widthSlider;
    public Slider lengthSlider;


    public GameObject heightTextObject;
    public GameObject widthTextObject;
    public GameObject lengthTextObject;
    public GameObject volumeTextObject;
    public GameObject edgeTextObject;

    private TextMeshProUGUI heightText { get; set; }
    private TextMeshProUGUI widthText { get; set; }
    private TextMeshProUGUI lengthText { get; set; }
    private TextMeshProUGUI volumeText { get; set; }
    private TextMeshProUGUI edgeText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        widthText = widthTextObject.GetComponent<TextMeshProUGUI>();
        lengthText = lengthTextObject.GetComponent<TextMeshProUGUI>();
        volumeText = volumeTextObject.GetComponent<TextMeshProUGUI>();
        edgeText = edgeTextObject.GetComponent<TextMeshProUGUI>();

        // Calls basic constructor, but sets height and width to 0
        myCube = new Cube();

        GetValuesFromSliders();
    }

    // Update is called once per frame
    void Update()
    {
        heightText.text = "Cube Height: " + myCube.GetHeight().ToString();
        widthText.text = "Cube Width: " + myCube.GetWidth().ToString();
        lengthText.text = "Cube Length: " + myCube.GetLength().ToString();
        volumeText.text = "Cube Volume: " + myCube.GetVolume().ToString();
        edgeText.text = "Cube Edge: " + myCube.GetEdge().ToString();
    }

    public void SliderChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myCube.SetHeight(heightSlider.value);
        myCube.SetWidth(widthSlider.value);
        myCube.SetLength(lengthSlider.value);
    }
}
