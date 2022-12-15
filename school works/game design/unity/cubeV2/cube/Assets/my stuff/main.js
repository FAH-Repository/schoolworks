var isQuit = false;
var isControls = false;


function OnMouseUp() {
    //is this quit
    if (isQuit == true) {
        //quit the game
        Application.Quit();
        
    }
    if (isControls == true) {
        Application.LoadLevel(1);


    }
        else {
            //load level
            Application.LoadLevel(3);
    }

    }



function Update() {
    //quit game if escape key is pressed
    if (Input.GetKey(KeyCode.Escape)) {
        Application.Quit();
    }


} function update() {
    if (Input.GetKey(KeyCode.leftClick)) {
        Application.LoadLevel(3);
    }
}
