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
        if (!TopLeftCorner) { BGDetails[BGDetails.Length - 4].sprite = null; }
        if (!TopRightCorner) { BGDetails[BGDetails.Length - 3].sprite = null; }
        if (!BottomLeftCorner) { BGDetails[BGDetails.Length - 2].sprite = null; }
        if (!BottomRightCorner) { BGDetails[BGDetails.Length - 1].sprite = null; }
    }
}
