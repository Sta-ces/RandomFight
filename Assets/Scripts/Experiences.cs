using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Experiences
{
    private static float m_experiencePlayer = 0;
    public static float ExperiencePlayer
    {
        get { return m_experiencePlayer; }
        set { m_experiencePlayer = value; }
    }

    public static void ExpPlus(float _expPlus)
    {
        m_experiencePlayer += _expPlus;
    }
}
