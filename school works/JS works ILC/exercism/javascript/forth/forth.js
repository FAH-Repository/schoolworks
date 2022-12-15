export class Forth {
  constructor() {
    this._stack = [];
    this._operators = {
      '+': this._executeOperator((a, b) => this._stack.push(b + a), 2),
      '-': this._executeOperator((a, b) => this._stack.push(b - a), 2),
      '*': this._executeOperator((a, b) => this._stack.push(b * a), 2),
      '/': this._executeOperator((a, b) => {
        if (a === 0) {
          throw new Error('Division by zero');
        }
        this._stack.push(Math.floor(b / a));
      }, 2),
      dup: this._executeOperator(a => {
        this._stack.push(a);
        this._stack.push(a);
      }, 1),
      drop: this._executeOperator(() => {}, 1),
      swap: this._executeOperator((a, b) => {
        this._stack.push(a);
        this._stack.push(b);
      }, 2),
      over: this._executeOperator((a, b) => {
        this._stack.push(b);
        this._stack.push(a);
        this._stack.push(b);
      }, 2),
    };
  }

  evaluate(str) {
    const list = str.split(/\s+/).map(s => s.toLowerCase());
    const [head, name, ...rest] = list;
    if (/:/.test(head)) {
      this._defineOperator(name, ...rest);
    } else {
      for (const item of list) {
        if (/\-?\d+/.test(item)) {
          this._stack.push(Number(item));
        } else if (
          Object.prototype.hasOwnProperty.call(this._operators, item)
        ) {
          this._operators[item]();
        } else {
          throw new Error('Unknown command');
        }
      }
    }
  }

  _defineOperator(name, ...definitions) {
    if (!/^\-?\d+$/.test(name) && definitions.pop() === ';') {
      const definedFunc = () => this.evaluate(definitions.join(' '));
      this._operators[name] = definedFunc;
    } else {
      throw new Error('Invalid definition');
    }
  }

  _executeOperator(func, num) {
    return () => {
      const x = Array.from({ length: num }, () => {
        const tmp = this._stack.pop();

        if (tmp === undefined) {
          throw new Error('Stack empty');
        } else {
          return tmp;
        }
      });

      return func(...x);
    };
  }

  get stack() {
    return this._stack;
  }
}