using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreenManager : MonoBehaviour
{
    const string TALKPANELTOGGLETAG = "TalkPanelToggle";
    [SerializeField] Toggle _dontShowToggle;
    [SerializeField] GameObject _talkPanel;
    private void Start()
    {
        _talkPanel.SetActive(!bool.Parse(PlayerPrefs.GetString(TALKPANELTOGGLETAG, "false")));
    }
    public void _StartGame()
    {
        BAHMANLoadingManager._INSTANCE._LoadScene(2);
    }
    public void _ExitClicked()
    {
        Application.Quit();
    }
    public void _InfoClicked()
    {
        _talkPanel?.SetActive(true);
        _dontShowToggle.isOn = bool.Parse(PlayerPrefs.GetString(TALKPANELTOGGLETAG, "false"));
    }
    public void _Donate(int iType) {
        DonateType tp =(DonateType) iType;
        switch (tp) {
            case DonateType.Like:
                break;
            case DonateType.Love:
                break;
            case DonateType.Insane:
                break;
        }
    }
    private void Reset()
    {
        PlayerPrefs.DeleteKey(TALKPANELTOGGLETAG);
    }
    public void _DontShowToggle()
    {
        PlayerPrefs.SetString(TALKPANELTOGGLETAG, _dontShowToggle.isOn.ToString());
    }
}

public enum DonateType {Like,Love,Insane }
