using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterController_WithKeyboard : MonoBehaviour {
    
    public enum e_CharacterMoves
    {
        IDLE,
        FORWARD,
        LEFT,
        RIGHT
    }
    public e_CharacterMoves m_CharacterMoves = e_CharacterMoves.IDLE;


    private void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        m_rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    private void Update()
    {
        switchMovesCharacter();
    }


    private void switchMovesCharacter()
    {
        switch (m_CharacterMoves)
        {
            case e_CharacterMoves.IDLE:
                break;
            case e_CharacterMoves.FORWARD:
                m_rigidbody.AddForce(Vector3.forward * 10f);
                break;
            case e_CharacterMoves.LEFT:
                break;
            case e_CharacterMoves.RIGHT:
                break;
        }

        //m_CharacterMoves = e_CharacterMoves.IDLE;
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100f, 20f), "Forward"))
            m_CharacterMoves = e_CharacterMoves.FORWARD;
    }


    private Rigidbody m_rigidbody;
}
