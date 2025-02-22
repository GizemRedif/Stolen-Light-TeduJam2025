using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Transform areaTransform;

    void Start()
    {
        areaTransform = GetComponent<Transform>();
    }
    private void Update() {
        if(Input.GetKey(KeyCode.E)){
            changetoBlue();
        }
    }
    public void changetoBlue(){
        areaTransform.localScale = new Vector3(3,3,1);
    }
    public void ChangeRed(){
        areaTransform.localScale = new Vector3(2,2,1);
    }
}

