using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    public GameObject m_Player;
    public Camera m_Camera;
    public Vector3 m_PositionCamera = new Vector3(0f,4f,-4f);
    public Vector3 m_RotationCamera = new Vector3(30f,0f,0f);

    private void Awake()
    {
        if (m_Player == null)
            m_Player = gameObject;

        if (m_Camera == null)
            m_Camera = Camera.main;
    }

    private void Start()
    {
        // Set on parent to Player
        m_Camera.transform.parent = m_Player.transform;

        m_Camera.transform.localPosition = m_PositionCamera;
        m_Camera.transform.localRotation = Quaternion.Euler(m_RotationCamera);
    }
}
