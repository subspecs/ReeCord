using UnityEngine;
using UnityEngine.UI;

public class WindowBackgroundManager : MonoBehaviour
{
    public Color WindowBGColor;
    [Space]

    public Image[] BGDetails;
    [Space]

    public bool TopLeftCorner = true;
    public bool TopRightCorner = true;
    public bool BottomLeftCorner = true;
    public bool BottomRightCorner = true;

    private bool FirstColorLoad = true;

    [HideInInspector]
    public float RCoef;
    [HideInInspector]
    public float GCoef;
    [HideInInspector]
    public float BCoef;

    [HideInInspector]
    public float LumValue;

    // Start is called before the first frame update
    void Start()
    {
        UpdateWindowSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Main Methods.
    public void SetWindowColor(Color Color)
    {
        WindowBGColor = Color;
        if (BGDetails != null) { int n = 0; while (n < BGDetails.Length) { BGDetails[n].color = Color; n++; }; }
    }
    public void UpdateWindowSettings()
    {
        SetWindowColor(WindowBGColor);
        if (FirstColorLoad) { var C32 = (Color32)WindowBGColor; LumValue = (C32.r + C32.g + C32.b) / 765f; FirstColorLoad = false; }
        if (!TopLeftCorner) { BGDetails[BGDetails.Length - 4].sprite = null; }
        if (!TopRightCorner) { BGDetails[BGDetails.Length - 3].sprite = null; }
        if (!BottomLeftCorner) { BGDetails[BGDetails.Length - 2].sprite = null; }
        if (!BottomRightCorner) { BGDetails[BGDetails.Length - 1].sprite = null; }
    }
}
