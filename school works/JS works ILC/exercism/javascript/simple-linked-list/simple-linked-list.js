export class Element {
  constructor(val = [], next = null) {
    this._value = val
    this._next = next
  }
  get value() {
    return this._value
  }
  get next() {
    return this._next 
  }
}

export class List {
  constructor(init) {
    this._list = []
    this._head = null
    this.init(init)
  }
  init(init) {
    if(init && init.length > 0) {
      init.map(number => {
        this.add(number)
      })
    }
  }
  add(nextValue) {
    if (this._list.length > 0) {
      this._list = [new Element(nextValue.value ? nextValue.value : nextValue, this._list[0]), ...this._list]
    } else {
      this._list.push(nextValue.value ? nextValue : new Element(nextValue))
    }
  }
  get length() {
    return this._list.length
  }
  get head() {
   if(this._list.length > 0) {
     return this._head = this._list[0]
   } else {
     return this._head
   }
  }
  toArray() {
    let newArray = []
    this._list.map(element => {
      newArray.push(element.value)
    })
    return newArray
  }
  reverse() {
   return new List(this.toArray())
  }
}