Documentation!

Created a main menu scene and a pause menu. The pause menu is in the prefab as a PauseMenu and a PauseMenuManager object.
These two needs to be setup together, this means when importing the PauseMenu you need to also import the PauseMenuManager.
You need to setup the buttons with the PauseMenuManager, this is done by dragging the PauseMenuManager into the onClick field on the buttons and then selecting what functions the buttons should take. On the PauseMenuManager Object you need to import the PauseMenu into the script.
