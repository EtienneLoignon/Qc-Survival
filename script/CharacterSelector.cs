using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour {

    private GameObject[] characterList;
    private int index;


    private void Start()
    {

        index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];

        //Remplir la chaine avec nos objets
        for(int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }


        //On enleve leur rendu
        foreach(GameObject go in characterList)
        {
            go.SetActive(false);
        }

        //On fait apparaitre celui qui est sur le premier index
        if(characterList[index])
        {
            characterList[index].SetActive(true);
        }

    }

    public void ToggleLeft() {

        //Pour selectionner d'autres objets
        characterList[index].SetActive(false);



        index--;
        if (index < 0) {

            index = characterList.Length - 1;
}
            //pour selectionner d'autres objets
            characterList[index].SetActive(true);



        
            
    }


    public void ToggleRight()
    {

        //Pour selectionner d'autres objets
        characterList[index].SetActive(false);



        index++;
        if (index == characterList.Length)
        {

            index = 0;
}
            //pour selectionner d'autres objets
            characterList[index].SetActive(true);



        

    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("Niveau1"); 
    }

}
