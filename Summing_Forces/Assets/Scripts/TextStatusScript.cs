using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextStatusScript : MonoBehaviour
{
    public bool isBalanced;
    public float interval;
    private float timer;
    private Text statText;
    // Start is called before the first frame update
    void Start()
    {
        statText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Blink();
        CheckStatus();
    }

    void CheckStatus(){
        if(isBalanced){
            statText.color = Color.green;
            statText.text = "Forces Balanced.";
        }
        else{
            statText.color = Color.red;
            statText.text = "ERROR: Forces Unbalanced.";
        }
    }

    void Blink(){
        timer += Time.deltaTime;

        if(timer >= interval)
        {
            if(statText.enabled == false){
                statText.enabled = true;
            }
            else{
                statText.enabled = false;
            }
            timer = 0;
        }
    }
}
