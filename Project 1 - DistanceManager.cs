using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistanceManager : MonoBehaviour
{
    private Distance myDistance;

    public Slider speedSlider;
    public Slider timeSlider;

    public GameObject speedTextObject;
    public GameObject timeTextObject;
    public GameObject distanceTextObject;

    private TextMeshProUGUI speedText { get; set; }
    private TextMeshProUGUI timeText { get; set; }
    private TextMeshProUGUI distanceText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        speedText = speedTextObject.GetComponent<TextMeshProUGUI>();
        timeText = timeTextObject.GetComponent<TextMeshProUGUI>();
        distanceText = distanceTextObject.GetComponent<TextMeshProUGUI>();

        // Calls basic constructor, but sets speed and time to 0
        myDistance = new Distance();

        GetValuesFromSliders();
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed (mph): " + myDistance.GetSpeed().ToString();
        timeText.text = "Time (hrs): " + myDistance.GetTime().ToString();
        distanceText.text = "Distance (m): " + myDistance.GetDistance().ToString();
    }

    public void SliderChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myDistance.SetSpeed(speedSlider.value);
        myDistance.SetTime(timeSlider.value);
    }
}
