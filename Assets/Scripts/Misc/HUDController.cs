using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("The part of the health that increases")]
    private RectTransform m_HeatlhBar;
    #endregion

    #region Private Variables
    private float p_HealthBarOrigWidth;
    #endregion

    #region Initialization
    private void Awake()
    {
        p_HealthBarOrigWidth = m_HeatlhBar.sizeDelta.x;
    }
    #endregion

    #region Update Health Bar
    public void UpdateHealth(float percent)
    {
        m_HeatlhBar.sizeDelta = new Vector2(p_HealthBarOrigWidth * percent, m_HeatlhBar.sizeDelta.y);
    }
    #endregion
}
