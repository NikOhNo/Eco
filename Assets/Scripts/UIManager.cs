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

    bool attacking;
    


    void Awake(){
        pc = new PlayerControls();
        pc.Enable();
        pc.MainGame.RightClick.performed += _ => RightClick();
        // pc.MainGame.LeftClick.performed += _ => LeftClick();
        mainCamera = Camera.main;

        gr = this.GetComponent<GraphicRaycaster>();
        ped =  new PointerEventData(null);

        results = new List<RaycastResult>();
    }

    public void ChangePhase(){
        Debug.Log("Meowng time!");
        //If now endphase, change it to endphase
    }

    public void SelectGameObject(GameObject obj){
        if (selectOne != null){
            selectOne = obj;
        }else if(selectTwo != null){
            selectOne = obj;
        }
    }

    void LeftClick(){
        ped.position = Input.mousePosition;
        gr.Raycast(ped, results);

        if(results.Count != 0){
            if(results[0].gameObject.GetComponent<Card>() && attacking){
                selectOne = results[0].gameObject;
                
                if(selectOne == null){

                }else if(true){
                    
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
