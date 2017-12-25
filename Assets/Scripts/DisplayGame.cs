using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGame
{
	public void DisplayText(Text _location, string _text)
    {
        _location.text = _text;
    }

    public void UIExperience(Button _button, float _percentage)
    {
        _button.GetComponent<Image>().fillAmount = Mathf.Clamp01(_percentage);
    }
}
