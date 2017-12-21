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

    public void UIExperience(Button _button, float _exp, int _max)
    {
        Calcul percCalcul = new Calcul();
        float percentage = percCalcul.Percentage(_exp,_max) / 100;
        _button.GetComponent<Image>().fillAmount = percentage;
    }
}
