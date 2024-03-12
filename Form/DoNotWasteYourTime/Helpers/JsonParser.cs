using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DoNotWasteYourTime.Models;

public class JsonParser
{
    public T JsonToModelResultParse<T> (string json) where T : class , new()
    {
        if (string.IsNullOrEmpty(json))
            return null;
        
        try
        {
            T deserializeObject = (JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto
            }));
            
            return deserializeObject;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.ToString());
            return null;
        }
    }   
    
    public string ModelToJsonResultParse<T>(IList<IBlockedSiteGroup> model) where T : class , new()
    {
        try
        {
            string json = JsonConvert.SerializeObject(typeof(T), Formatting.Indented, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
           
            return json;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.ToString());
            return null;
        }
    }
    
}