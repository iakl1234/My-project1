using UnityEngine;

public class Header : MonoBehaviour
{
    private void Awake()
    {
       //this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, 308);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void Button_back()
    {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
