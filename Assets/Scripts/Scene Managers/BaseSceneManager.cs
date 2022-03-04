using UnityEngine;
using UnityEngine.UI;

public class BaseSceneManager : MonoBehaviour
{
    public TMPro.TMP_Text TopChannelTitle;
    public Image TopChannelTitleIcon;

    public TMPro.TMP_Text TopServerTitle;
    public Image TopServerTitleIcon;

    public WindowBackgroundManager[] WindowManagers;

    // Start is called before the first frame update
    void Start()
    {
        WindowManagers = transform.GetComponentsInChildren<WindowBackgroundManager>();

        SetColorTheme(new Color32(192, 192, 255, 255), 300f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Main Methods.
    public void SetColorTheme(Color32 Color, float BrigtnessAlterPercent = 0)
    {
        int n = 0; BrigtnessAlterPercent = (BrigtnessAlterPercent / 100f) + 1;
        while (n < WindowManagers.Length)
        {
            float SR = Color.r * WindowManagers[n].LumValue * BrigtnessAlterPercent, SG = Color.g * WindowManagers[n].LumValue * BrigtnessAlterPercent, SB = Color.b * WindowManagers[n].LumValue * BrigtnessAlterPercent; SR = SR > 255 ? 255 : SR; SG = SG > 255 ? 255 : SG; SB = SB > 255 ? 255 : SB;
            WindowManagers[n].SetWindowColor(new Color32((byte)System.Math.Ceiling(SR), (byte)System.Math.Ceiling(SG), (byte)System.Math.Ceiling(SB), 255));
            n++;
        }
    }
}
