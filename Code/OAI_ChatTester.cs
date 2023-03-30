
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using UnityEngine;
using UnityEngine.UI;

public class OAI_ChatTester : MonoBehaviour
{
    public Text text;
    public  Text inputFildText;
    private string postText;
    string ReqestText = "";
    IOpenChatAPI OAI_Chat;
    // Start is called before the first frame update
    void Start()
    {
        OAI_Chat = this.gameObject.GetComponent<OAI_Chat>();
        this.gameObject.GetComponent<OAI_Chat>().CompletedRepostEvent = delegate (string _string) { postText = _string; };
    }

    public void Reqest()
    {
        ReqestText = (inputFildText.text.ToString());
        Test();
    }

    private async void Test()
    {
        //OAI_Chat.ReqestStringData(b);
        //Debug.Log(b);
        postText = (await this.gameObject.GetComponent<OAI_Chat>().AsyncReqesStringtData(ReqestText, _SendMessageDebugLog: true));
        
    }
    private void Update()
    {
       text.text = postText;
    }
}