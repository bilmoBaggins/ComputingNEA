using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProjectileMotion : MonoBehaviour
{
    // variables

    public float u { get; set; } = 20f;                  //given by user
    public float s { get; set; } = 1f;                   //given by user
    public float thetaDegrees { get; set; } = 30f;       //given by user
    public float h { get; set; } = 0f;                   //given by user

    public float a = -9.81f;                             //given constant

    public float uVERT;                                  //calculated
    public float uHORI;                                  //calculated
    public float t;                                      //calculated
    public float v;                                      //calculated
    public float hMAX;                                   //calculated

    // text display

    public GameObject initalVelocity;
    public GameObject distanceTravelled;
    public GameObject theta;
    public GameObject elevation;

    public GameObject verticalVelocity;
    public GameObject horizontalVelocity;
    public GameObject time;
    public GameObject finalVelocity;
    public GameObject maxHeight;

    TextMeshProUGUI uText_text;
    TextMeshProUGUI sText_text;
    TextMeshProUGUI thetaText_text;
    TextMeshProUGUI hText_text;

    TextMeshProUGUI uVERTText_text;
    TextMeshProUGUI uHORIText_text;
    TextMeshProUGUI tText_text;
    TextMeshProUGUI vText_text;
    TextMeshProUGUI hMAXText_text;

    // Start is called before the first frame update
    void Start()
    {
        uText_text = initalVelocity.GetComponent<TextMeshProUGUI>();
        sText_text = distanceTravelled.GetComponent<TextMeshProUGUI>();
        thetaText_text = theta.GetComponent<TextMeshProUGUI>();
        hText_text = elevation.GetComponent<TextMeshProUGUI>();

        uVERTText_text = verticalVelocity.GetComponent<TextMeshProUGUI>();
        uHORIText_text = horizontalVelocity.GetComponent<TextMeshProUGUI>();
        tText_text = time.GetComponent<TextMeshProUGUI>();
        vText_text = finalVelocity.GetComponent<TextMeshProUGUI>();
        hMAXText_text = maxHeight.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // calculate variables

        float theta = (Mathf.PI / 180) * thetaDegrees;
        uVERT = u * (Mathf.Sin(theta));
        uHORI = u * (Mathf.Cos(theta));

        float tempv = Mathf.Sqrt((u * u) + 2 * a * s);

        t = (s / uHORI) + (h / tempv);

        v = Mathf.Sqrt((tempv * tempv) + 2 * a * h);

        hMAX = ((-(u * u)) / (2 * a)) + h;


        // display variables

        uText_text.text = u.ToString();
        sText_text.text = s.ToString();
        thetaText_text.text = theta.ToString();
        hText_text.text = h.ToString();

        uVERTText_text.text = uVERT.ToString();
        uHORIText_text.text = uHORI.ToString();
        tText_text.text = t.ToString();
        vText_text.text = v.ToString();
        hMAXText_text.text = hMAX.ToString();
    }
}
