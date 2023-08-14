using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSizer : MonoBehaviour
{
    [SerializeField] private float m_speed;

    public void OpenPortal()
    {
        if (gameObject.transform.localScale.x < 1f )
        {
            gameObject.transform.localScale += new Vector3(m_speed, m_speed, m_speed) * Time.fixedDeltaTime;
        }
    }

    public void ClosePortal()
    {
        if (gameObject.transform.localScale.x > 0f)
        {
            gameObject.transform.localScale -= new Vector3(m_speed, m_speed, m_speed) * Time.fixedDeltaTime;
        }
    }
}
