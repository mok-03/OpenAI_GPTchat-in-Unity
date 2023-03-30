using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOpenChatAPI
{
    public string ReqestStringData(string messageString, bool DataAutoAdd = true, bool SendMessageDebugLog = false);
    public void DataAdd(string text, message.role _Role = message.role.assistant);
    public void DataErease(int number, int count);
    public void ResetData();
   

}
