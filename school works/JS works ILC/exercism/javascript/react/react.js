export class Cell {
  constructor(value) {
    this.value = value;
    this.children = [];
    this.state = true;
  }
  setChildrenState(){
    if(this.children != []) {
      this.children.forEach(child => {
        child.state = false;
        child.setChildrenState();
      });
    }
  }
}

export class InputCell extends Cell {
  constructor(value){
    super(value);
  }
  setValue(value) {
    this.value = value;
    this.setChildrenState();
    this.children != [] && this.children.forEach(child => child.update());
  }
}

export class ComputeCell extends Cell {
  constructor(inputCells, fn){
    super();
    this.parents = inputCells;
    this.function = fn;
    this.value = fn(inputCells);
    this.callbacks = [];
    this.previousValue = this.value;
    inputCells.forEach(cell => cell.children.push(this));
  }
  update(){
    this.setChildrenState();
    if(this.parents.every(parent => parent.state === true)
      && (this.previousValue != this.function(this.parents))){
      this.value = this.function(this.parents);
      this.state = true;
      this.previousValue = this.value;
    }
    if (this.callbacks != []
      && this.state === true){
        this.callbacks.forEach(cb => cb.call(this))
    }
    if(this.children != []) {
      this.children.forEach(child => child.update());
    }
  }
  addCallback(cb) {
    this.callbacks.push(cb);
  }
  removeCallback(cb) {
    this.callbacks = this.callbacks.filter(x => x != cb);
  }
}

export class CallbackCell {
  constructor(fn) {
    this.fn = fn;
    this.values = []
  }
  call(cell){
    this.values.push(this.fn(cell));
  }
}