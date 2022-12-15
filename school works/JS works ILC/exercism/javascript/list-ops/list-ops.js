export class List {
  constructor(values) {
    this.values = values || [];
  }

  append(appended) {
      return new List ([...this.values, ...appended.values]);
  }

  concat(listseries) {
    let tempvalues = [...this.values];
    listseries.values.forEach ( (object) => {
      tempvalues.push(...object.values)
    });
    return new List (tempvalues);
  }

  filter(func) {
    let tempvalues = [];
    let i=0;
    while (this.values[i]){
      if (func(this.values[i])){
        tempvalues.push(this.values[i]);
      }
      i++;
    }
    return new List(tempvalues);
  }

  //returns new array
  map(func) {
    let tempvalues = [];
    let i=0;
    while (this.values[i]){
      tempvalues[i] = func(this.values[i])
      i++;
    }
    return new List(tempvalues)
  }

  length() {
    let i=0;
    while(this.values[i]){
      i++;
    }
    return i;
  }

  foldl(func, acc) {
    this.values.forEach((el)=> {
      acc = func(acc,el)
    })
    return acc;
  }

  foldr(func, acc) {
    for (let i= this.length() -1; i >=0; i--){
      acc = func(acc,this.values[i])
    }
    return acc;
  }

  reverse() {
    let reversedvals =[];
    for (let i= this.length()-1 ; i>=0; i--){
      reversedvals.push(this.values[i]);
    }
    return new List(reversedvals)
  }
}