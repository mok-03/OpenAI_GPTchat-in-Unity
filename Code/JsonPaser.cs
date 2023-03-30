using System;
using System.IO;
using UnityEngine;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


static public class JsonPaser
{

    static public T Load<T>(string FileLocation) where T : class
    {

        try
        {
            var jsonFile = File.ReadAllText(FileLocation);
            var data = JsonUtility.FromJson<T>(jsonFile) as T;
            return data;
        }
        catch (Exception e)
        {
            throw new JsonException("err Loder" + e);

        }
        return default(T);
    }

    static public void Save<T>(string FileLocation, T data) where T : class
    {
        try
        {
            var a = (JsonUtility.ToJson(data));
            File.WriteAllText(FileLocation, a);
            // var dataa = JsonConvert.DeserializeObject(a) as T;

        }
        catch (Exception e)
        {
            Debug.LogWarning(e);

        }

    }
}