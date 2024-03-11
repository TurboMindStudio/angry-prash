using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Cinemachine;
using StarterAssets;

public class camDragHandler : MonoBehaviour ,IPointerDownHandler,IDragHandler,IPointerUpHandler
{
    

    public Image imageCamControlArea;
    public float camSensitivity;
    public ThirdPersonController thirdPersonController;

    void Start()
    {
        
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(imageCamControlArea.rectTransform, eventData.position, eventData.enterEventCamera, out Vector2 posOut))
        {

            thirdPersonController.CameraRotation(camSensitivity);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        thirdPersonController.CameraRotation(0f);
    }

}




