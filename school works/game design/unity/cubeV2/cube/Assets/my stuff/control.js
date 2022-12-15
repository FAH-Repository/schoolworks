
var isBack = false;

function OnMouseUp() {
    //is this quit
    
        if (isBack == true) {
            Application.LoadLevel(0);
        }
}
function update() {
    if (Input.GetKey(KeyCode.leftClick)) {
        Application.LoadLevel(0);
    }
}