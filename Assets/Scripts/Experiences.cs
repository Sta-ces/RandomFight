using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Experiences
{
    public int ExperiencePlayer
    {
        get { return m_experiencePlayer; }
        set { m_experiencePlayer = value; }
    }


    public void ExpPlus(int _expPlus)
    {
        m_experiencePlayer += _expPlus;
    }

    private int m_experiencePlayer = 0;
}
