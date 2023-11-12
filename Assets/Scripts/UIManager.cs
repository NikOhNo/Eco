using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] GameObject selectOne = null;
    [SerializeField] GameObject selectTwo = null;
    [SerializeField] PlayerControls pc;
    [SerializeField] GraphicRaycaster gr;
    List<RaycastResult> results;
    PointerEventData ped;
    Camera mainCamera;

    [SerializeField] bool attacking;
    


    void Awake(){
        pc = new PlayerControls();
        pc.Enable();
        pc.MainGame.RightClick.performed += _ => RightClick();
        pc.MainGame.LeftClick.performed += _ => LeftClick();
        mainCamera = Camera.main;

        gr = this.GetComponent<GraphicRaycaster>();
        ped =  new PointerEventData(null);

        results = new List<RaycastResult>();
    }

    public void ChangePhase(){
        Debug.Log("Meowng time!");
        //If now endphase, change it to endphase
    }

    void LeftClick(){
        ped.position = Input.mousePosition;
        gr.Raycast(ped, results);

        if(results.Count != 0){
            if(results[0].gameObject.GetComponent<Card>() && attacking){
                
                if(selectOne == null){
                   selectOne = results[0].gameObject; 
                   Debug.Log("Attacker Selected");
                }else if(selectOne != null && selectTwo == null){
                    selectTwo = results[0].gameObject;
                    Debug.Log("Target Selected");
                    //Send to the attacking zone
                    selectOne = null;
                    selectTwo = null;
                }

            }
            results.Clear();
        } else if(selectOne != null){
            results.Clear();
        }
    }

    void RightClick(){
        Debug.Log("RIght CLick!");

        ped.position = Input.mousePosition;
        gr.Raycast(ped, results);

        if(results.Count != 0){
            Debug.Log(results[0].gameObject);
            if(results[0].gameObject.GetComponent<Card>()){
                //Big Display
            }
            results.Clear();
        }
    }

    


}
