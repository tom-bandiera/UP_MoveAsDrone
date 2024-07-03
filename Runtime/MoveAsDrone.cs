using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsDrone : MonoBehaviour
{
    [SerializeField] float m_moveSpeed;
    [SerializeField] float m_rotateSpeed;

    public float m_moveXAxisValue;
    public float m_moveYAxisValue;
    public float m_moveZAxisValue;
    public float m_rotateYAxisValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(m_moveXAxisValue, m_moveYAxisValue, m_moveZAxisValue) * m_moveSpeed * Time.deltaTime, Space.Self) ;
        transform.Rotate(new Vector3(0, m_rotateYAxisValue, 0) * m_rotateSpeed * Time.deltaTime);
    }

    public void SetMoveXAxisValue(float _value)
    {
        m_moveXAxisValue = _value;
    }

    public void SetMoveZAxisValue(float _value)
    {
        m_moveZAxisValue = _value;
    }

    public void SetMoveUpYValue(float _value)
    {
        m_moveYAxisValue = _value;
    }

    public void SetMoveDownYValue(float _value)
    {
        m_moveYAxisValue = -_value;
    }

    public void SetRotateYValue(float _value)
    {
        m_rotateYAxisValue = _value;
    }
}
