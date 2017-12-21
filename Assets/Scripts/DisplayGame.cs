using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGame
{
	public DisplayGame(Text _location, string _text)
    {
        _location.text = _text;
    }
}
