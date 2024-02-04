using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well1Script : MonoBehaviour
{
    //public int appearance;
    public GameObject NumOfPebbles;
    public int row = 0;
    public int col = 0;
    public bool action = false;



    // Start is called before the first frame update
    void Start()
    {
        //appearance = GameEngine.wells[1,1]; //Referencing the wells from the GameEngine file
        //Debug.Log(appearance);
        Instantiate(NumOfPebbles, transform.position, transform.rotation);
    }
    

    // Update is called once per frame 
    void Update() {
        while(action == false) {
    void OnMouseDown()
    {
        action = true;
        // Your action or code to execute on click (next time use math to calculate and return the position)
        Debug.Log("Sprite Clicked!");
        
        if((transform.position.x > -3.5) && (transform.position.x <-2.5)) {
            col=1;
            Debug.Log("Col 1");
        } else if((transform.position.x > -1.5) && (transform.position.x < -1)) {
            col=2;
            Debug.Log("Col 2");
        } else if((transform.position.x > 0.5) && (transform.position.x < 1)){
            col=3;
            Debug.Log("Col 3");
        } else if((transform.position.x >2.5) && (transform.position.x < 2.80)) {
            col=4;
            Debug.Log("Col 4");
        } else if((transform.position.x >2.80) && (transform.position.x < 3)) {
            col=5;
            Debug.Log("Col 5");
        } else if((transform.position.x >2.80) && (transform.position.x < 3)){
            col = 0;
            Debug.Log("Col 0");
        } 

        if(transform.position.y < 0) {
            row = 1;
            Debug.Log("Row 1");
        } else{
            row = 0;
            Debug.Log("Row 0");
        }
        action = false;
    }
    }
    }
}
