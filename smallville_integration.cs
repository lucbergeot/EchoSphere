using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class SmallvilleIntegration : MonoBehaviour
{
    private const string SERVER_URL = "http://localhost:10000/projects/NPC-memory-storage/applications/TOPIC";

    [System.Serializable]
    public class GenerateTopicRequest
    {
        public string npc1_id;
        public string npc2_id;
    }

    [System.Serializable]
    public class LogInteractionRequest
    {
     public string npc1_id;
     public string npc2_id;
     public string topic;
     public string conversation_summary;
     public string emotional_tone;
     public float impact;
    }


    public IEnumerator GetConversationTopic(string npc1Id, string npc2Id, System.Action<string> onTopicGenerated)
    {
        string url = $"{SERVER_URL}/generate_topic";
        // Log the URL and IDs being used
        Debug.Log($"Attempting to connect to server at: {SERVER_URL} with NPC1: {npc1Id}, NPC2: {npc2Id}");

       GenerateTopicRequest requestData = new GenerateTopicRequest { npc1_id = npc1Id, npc2_id = npc2Id };
       string jsonData = JsonUtility.ToJson(requestData);

        // Create the UnityWebRequest with the proper content type for JSON
        using (UnityWebRequest request = new UnityWebRequest(url, UnityWebRequest.kHttpVerbPOST))
        {
            byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(jsonData);
            request.uploadHandler = new UploadHandlerRaw(jsonToSend);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            Debug.Log("Sending request to the server...");

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log($"Server response: {request.downloadHandler.text}");
                TopicResponse response = JsonUtility.FromJson<TopicResponse>(request.downloadHandler.text);
                onTopicGenerated?.Invoke(response.topic);
            }
            else
            {
                Debug.LogError($"Error fetching topic: {request.error}");
                Debug.LogError($"Server response: {request.downloadHandler.text}");
                onTopicGenerated?.Invoke("General conversation");
            }
        }
    }

    public static IEnumerator LogInteraction(string npc1Id, string npc2Id, string topic, string conversationSummary, string emotionalTone, float impact)
    {
        string url = $"{SERVER_URL}/log_interaction";
        LogInteractionRequest requestData = new LogInteractionRequest
    {
        npc1_id = npc1Id,
        npc2_id = npc2Id,
        topic = topic,
        conversation_summary = conversationSummary,
        emotional_tone = emotionalTone,
        impact = impact
    };
    string jsonData = JsonUtility.ToJson(requestData);

        // Create the UnityWebRequest with the proper content type for JSON
        using (UnityWebRequest request = new UnityWebRequest(url, UnityWebRequest.kHttpVerbPOST))
        {
            byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(jsonData);
            request.uploadHandler = new UploadHandlerRaw(jsonToSend);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError($"Error logging interaction: {request.error}");
            }
        }
    }

    [System.Serializable]
    private class TopicResponse
    {
        public string topic;
    }
}
