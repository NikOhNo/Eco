using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ObjectClicker : MonoBehaviour, IPointerUpHandler, IPointerDownHandler 
{
    [SerializeField] UIManager ui;
    

    void Awake(){

    }
    
    public void OnPointerDown(PointerEventData eventData){
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // ui.SelectGameObject(this); //If attack phase 
    }



    // GraphicRaycaster ui_raycaster;
    // public GameObject ui_canvas;

    // PointerEventData click_data;
    // List<RaycastResult> click_results;


    // void Awake(){
    //     // ui = GameObject.FindObjectOfType (typeof(UIManager));

    //     ui_raycaster = ui_canvas.GetComponent<GraphicRaycaster>();
    //     click_data = new PointerEventData(EventSystem.current);
    //     click_results = new List<RaycastResult>();
    // }

    // void Update(){
    //     if(Mouse.current.leftButton.wasReleasedThisFrame){
    //         GetUiElementsClicked();
    //         Debug.Log("Released");
    //     }
    // }

    // void GetUiElementsClicked()
    // {
    //     click_data.position = Mouse.current.position.ReadValue();
    //     click_results.Clear();

    //     ui_raycaster.Raycast(click_data, click_results);

    //     foreach(RaycastResult result in click_results){
    //         GameObject ui_element = result.gameObject;

    //         Debug.Log(ui_element.name);

    //     }
    // }

    

}
