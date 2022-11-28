using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsScreen : MonoBehaviour
{
    public Toggle fullscreenTog, vsyncTog;

    public List<ResItem> resolutions = new List<ResItem>();
    private int selectedResolution;

    public TMP_Text resolutionLabel;

    void Start()
    {
        fullscreenTog.isOn = Screen.fullScreen; // Sprawdza czy gra jest w pelnym ekranie

        vsyncTog.isOn = QualitySettings.vSyncCount != 0;

        bool foundRes = false;
        for (int i = 0; i < resolutions.Count; i++)
        {
            if (Screen.width == resolutions[i].horizontal && Screen.height == resolutions[i].vertical)
            {
                foundRes = true;

                selectedResolution = i;

                UpdateResLabel();
            }
        }

        if(!foundRes) // Jesli gracz ma inna rozdzialke niz te wbudowane to dodaje sie ona do listy
        {
            ResItem newRes = new();
            newRes.horizontal = Screen.width;
            newRes.vertical = Screen.height;

            resolutions.Add(newRes);
            selectedResolution = resolutions.Count - 1;

            UpdateResLabel();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            ResLeft();

        if (Input.GetKeyDown(KeyCode.RightArrow))
            ResRight();
    }

    public void ResLeft() // Po wcisnieciu strzalki w lewo zmieniamy na wieksza rozdzialke
    {
        selectedResolution--;
        if(selectedResolution < 0)
        {
            selectedResolution = 0;
        }

        UpdateResLabel();
    }
    public void ResRight() // Po wcisnieciu strzalki w prawo zmieniamy na mniejsza rozdzialke
    {
        selectedResolution++;
        if(selectedResolution > resolutions.Count - 1)
        {
            selectedResolution = resolutions.Count - 1;
        }
        UpdateResLabel();
    }

    public void UpdateResLabel() // Aktualizuje napis z rozdzialkami
    {
        resolutionLabel.text = resolutions[selectedResolution].horizontal.ToString() + " x " + resolutions[selectedResolution].vertical.ToString();
    }

    public void Apply() // Wlacza ustawione przez gracza opcje
    {
        Screen.fullScreen = fullscreenTog.isOn;

        if(vsyncTog.isOn)
            QualitySettings.vSyncCount = 1;
        else
            QualitySettings.vSyncCount = 0;

        Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, fullscreenTog.isOn);
    }
}

[System.Serializable]
public class ResItem
{
    public int horizontal, vertical;
}