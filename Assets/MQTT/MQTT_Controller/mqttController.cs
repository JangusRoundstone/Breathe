using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mqttController : MonoBehaviour
{
    public string nameController = "Controller 1";
    public string tagOfTheMQTTReceiver = "MQTT";
    public mqttReceiver _eventSender;
    public TextMeshPro text;

    public float publishInterval = 1.0f; // Publish once every 1 second
    private float timer = 0f;

    void Start()
    {
        GameObject receiverObj = GameObject.FindWithTag(tagOfTheMQTTReceiver);
        if (receiverObj == null)
        {
            Debug.LogError($"No GameObject found with tag '{tagOfTheMQTTReceiver}'. Ensure it is in the scene.");
            return;
        }

        _eventSender = receiverObj.GetComponent<mqttReceiver>();
        if (_eventSender == null)
        {
            Debug.LogError("The found GameObject does not have an mqttReceiver component.");
            return;
        }

        _eventSender.OnMessageArrived += OnMessageArrivedHandler;
    }

    private void PublishMessage()
    {
        _eventSender.Publish();
        Debug.Log($"Published message from {nameController} at {Time.time}");
    }

    private void OnMessageArrivedHandler(string newMsg)
    {
        Debug.Log("Event Fired. The message, from Object " + nameController + " is = " + newMsg);
        text.text = newMsg;
    }
}
