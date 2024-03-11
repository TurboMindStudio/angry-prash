using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class worldDragHandler : MonoBehaviour,IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Image worldDragImg;
    Vector2 camInput;

    [SerializeField] CinemachineFreeLook[] TpsCam;

    private void Start()
    {
        worldDragImg = GetComponent<Image>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(worldDragImg.rectTransform, eventData.position, eventData.pressEventCamera, out camInput))
        {
            for (int i = 0; i < TpsCam.Length; i++)
            {
                TpsCam[i].m_XAxis.m_InputAxisName = null;
                TpsCam[i].m_YAxis.m_InputAxisName = null;
                TpsCam[i].m_XAxis.m_InputAxisValue = 0;
                TpsCam[i].m_YAxis.m_InputAxisValue = 0;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        OnDrag(eventData);
    }
}
