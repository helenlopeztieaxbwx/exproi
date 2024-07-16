using UnityEngine;
using UnityEngine.Networking;

public static IEnumerator UploadPaste(string data)
{
    using (UnityWebRequest www = UnityWebRequest.Post("https://your-server.com/upload", data))
    {
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Upload successful!");
        }
    }
}
