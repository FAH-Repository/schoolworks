class ListItem {
  constructor(content){
    this._content = content 
    this._previous = null
    this._next = null
  }
}

export class LinkedList {
  constructor(){
    this._first = null;
  }
  push(item) {
    if(this._first == null){
      this._first = new ListItem(item);
      this._first._next = this._first;
      this._first._previous = this._first;
    } else{
      let temp = new ListItem(item);
      this._first._previous._next = temp;
      temp._previous = this._first._previous;
      this._first._previous = temp;
      temp._next = this._first;
    }
  }

  pop() {
    if(this._first._next === this._first){
      let result = this._first._content;
      this._first = null;
      return result;
    }
    let temp = this._first._previous;
    temp._previous._next = this._first;
    this._first._previous = temp._previous;
    return temp._content;
  }
  
  shift() {
    if(this._first._next === this._first){
      let result = this._first._content;
      this._first = null;
      return result;
    }
    let temp = this._first;
    temp._previous._next = temp._next;
    temp._next._previous = temp._previous;
    this._first = temp._next;
    return temp._content;
  }

  unshift(content) {
    if(this._first === null) {
      this.push(content); 
      return;
    }
    let temp = new ListItem(content);
    temp._next = this._first;
    temp._previous = this._first._previous;
    temp._previous._next = temp;
    this._first._previous = temp;
    this._first = temp;
    return;
  }

  delete(toDelete) {
    if(this._first._content === toDelete) {this.shift(); return;}
    let temp = this._first._next;
    while(temp != this._first){
      if(temp._content === toDelete){
        temp._previous._next = temp._next;
        temp._next._previous = temp._previous;
        return;
      } else{
        temp = temp._next;
      }
    }
  }

  count() {
    if (this._first === null) {
      return 0;
    }
    let temp = this._first;
    let n = 1;
    while(temp._next != this._first){
      n++;
      temp = temp._next;
    }
    return n;
  }
}