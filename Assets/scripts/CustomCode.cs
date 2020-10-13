using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using Random=UnityEngine.Random;

public class CustomCode : MonoBehaviour
{
static public List<string> availableScenes = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"};
static public List<string> playedScenes = new List<string>() {};

public void RandomScene(){

if (availableScenes.Count == 0)

{
   availableScenes =   playedScenes;
  playedScenes = new List<string>() {};
 Debug.Log("Available Scenes: " +String.Join(",", availableScenes));
Debug.Log("Played Scenes: " +String.Join(",", playedScenes));
  Debug.Log("Scene Count: " +availableScenes.Count);
SceneManager.LoadScene(25);
} 
else 
{
string RandomScene = availableScenes [Random.Range (0,  availableScenes.Count)];
 print ("Selected Next Random scene: " + RandomScene);
 availableScenes.Remove(RandomScene);
 Debug.Log("Available Scenes: " +String.Join(",", availableScenes));
 playedScenes.Add(RandomScene);
  Debug.Log("Played Scenes: " +String.Join(",", playedScenes));
SceneManager.LoadScene(RandomScene);
 Debug.Log(" Current Scene Count: " +availableScenes.Count);
  
}
}
public void ResetScenes(){
    List<string> ResetAvailableSceneList = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"};
 List<string> ResetplayedSceneList = new List<string>() { };
 availableScenes =   ResetAvailableSceneList;
 playedScenes =   ResetplayedSceneList;
 SceneManager.LoadScene(0);
}
public void SelectedAnswer(){



}


}