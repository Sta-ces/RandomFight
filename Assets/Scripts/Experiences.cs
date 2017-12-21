using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Experiences
{
    private float m_experiencePlayer = 0;
    public float ExperiencePlayer
    {
        get { return m_experiencePlayer; }
        set { m_experiencePlayer = value; }
    }

    public void ExpPlus(float _expPlus)
    {
        m_experiencePlayer += _expPlus;
    }
}
